using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace _06.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransferenciaBancaria transferencia = new TransferenciaBancaria();

            try
            {
                ContaCorrente conta1 = new ContaCorrente(1, 100);
                ContaCorrente conta2 = new ContaCorrente(4, 50);
                Console.WriteLine(conta1);
                Console.WriteLine(conta2);

                //ContaCorrente conta3 = new ContaCorrente(-23, 50);
                transferencia.Efetuar(conta1, conta2, 3.5m);
                transferencia.Efetuar(conta1, conta2, 3500000000000m);
                //transferencia.Efetuar(conta3, conta1, 2.5m);
                transferencia.Efetuar(conta2, conta1, 3.5m);
                Console.WriteLine(conta1);
                Console.WriteLine(conta2);

                Console.WriteLine("Transferências realizadas com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }

    class ContaCorrente
    {
        public int Id { get; }
        public decimal Saldo { get; private set; }

        public ContaCorrente(int id, decimal saldo)
        {
            if (id <= 0)
            {
                throw new ArgumentException(nameof(id));
            }

            Id = id;
            Saldo = saldo;
        }

        public void Debitar(decimal valor)
        {
            if (Saldo < valor)
            {
                //throw new ArgumentException("saldo insuficiente");
                throw new SaldoInsuficienteException();
            }

            Saldo -= valor;
        }

        public void Creditar(decimal valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return $"Conta: {Id}, Saldo: {Saldo:C}";
        }
    }

    interface ITransferenciaBancaria
    {
        void Efetuar(ContaCorrente contaDebito, ContaCorrente contaCredito
            , decimal valor);
    }

    class TransferenciaBancaria : ITransferenciaBancaria
    {
        public void Efetuar(ContaCorrente contaDebito, ContaCorrente contaCredito
            , decimal valor)
        {
            Logger.LogInfo("Entrando do método Efetuar.");
            try
            {
                if (contaCredito == null)
                    throw new ArgumentNullException(nameof(contaCredito));
                if (contaDebito == null)
                    throw new ArgumentNullException(nameof(contaDebito));
                if (valor <= 0)
                    throw new ArgumentOutOfRangeException(nameof(valor));

                contaDebito.Debitar(valor);
                contaCredito.Creditar(valor);
                Logger.LogInfo("Transferência realizada com sucesso.");
            }
            catch (Exception exc)
            {
                Logger.LogErro(exc.ToString());
                throw;
            }
            Logger.LogInfo("Saindo do método Efetuar.");
        }
    }

    class TransferenciaBancaria_BD : ITransferenciaBancaria
    {
        private const string CONNECTION_STRING =
            @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB\ByteBank.mdf;Integrated Security=True";
        private const decimal TAXA_TRANSFERENCIA = 1.0m;
        private SqlConnection connection;
        private SqlTransaction transaction;

        public void Efetuar(ContaCorrente contaCredito, ContaCorrente contaDebito
            , decimal valor)
        {
            Logger.LogInfo("Entrando do método Efetuar.");

            connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            transaction = connection.BeginTransaction();

            SqlCommand comandoTransferencia = GetTransferenciaCommand
                (contaCredito.Id, contaDebito.Id, valor);
            SqlCommand comandoTaxa = GetTaxaTransferenciaCommand
                (contaCredito.Id, TAXA_TRANSFERENCIA);

            try
            {
                comandoTaxa.ExecuteNonQuery();
                comandoTransferencia.ExecuteNonQuery();
                transaction.Commit();
                Logger.LogInfo("Transferência realizada com sucesso.");
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                Logger.LogErro(ex.ToString());
                throw;
            }
            catch (Exception ex)
            {
                Logger.LogErro(ex.ToString());
                throw;
            }
            finally
            {
                comandoTransferencia.Dispose();
                transaction.Dispose();
                connection.Dispose();
            }
            Logger.LogInfo("Saindo do método Efetuar.");
        }

        private SqlCommand GetTransferenciaCommand(int contaDebitoId, int contaCreditoId, decimal valorTransferencia)
        {
            SqlCommand command = new SqlCommand("p_TRANSFERENCIA_BANCARIA_i", connection, transaction);
            command.Parameters.AddWithValue("@CONTA_ID_DEBITO", contaDebitoId);
            command.Parameters.AddWithValue("@CONTA_ID_CREDITO", contaCreditoId);
            command.Parameters.AddWithValue("@VALOR", valorTransferencia);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            return command;
        }

        private SqlCommand GetTaxaTransferenciaCommand(int contaId, decimal valorTransferencia)
        {
            SqlCommand command = new SqlCommand("p_TARIFA_TRANSFERENCIA_i", connection, transaction);
            command.Parameters.AddWithValue("@CONTA_ID", contaId);
            command.Parameters.AddWithValue("@VALOR", valorTransferencia);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            return command;
        }
    }

    [Serializable]
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string message) : base(message) { }
        public SaldoInsuficienteException(string message, Exception inner) : base(message, inner) { }
        protected SaldoInsuficienteException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public override string Message => "Saldo Insuficiente.";
    }

    class Logger
    {
        public static void LogInfo(string mensagem)
        {
            Log(mensagem, "INFO");
        }

        public static void LogErro(string mensagem)
        {
            Log(mensagem, "ERRO");
        }

        private static void Log(string mensagem, string tipo)
        {
            using (var sw = new StreamWriter("logs.txt", append: true))
            {
                sw.WriteLine(DateTime.Now.ToLocalTime() + ": " + tipo + " - " + mensagem);
            }
        }
    }
}
