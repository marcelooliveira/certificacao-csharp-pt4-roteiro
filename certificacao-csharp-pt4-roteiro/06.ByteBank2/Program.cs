using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _06.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            TransferenciaBancaria transferencia = new TransferenciaBancaria();
            transferencia.Efetuar(4, 1, 3.5m);
            transferencia.Efetuar(-4, 1, 3.5m);


            //try
            //{
            //    command.ExecuteNonQuery();
            //    transaction.Commit();
            //    Console.WriteLine("Transferência realizada com sucesso!");
            //}
            //catch (SqlException ex)
            //{
            //    Console.WriteLine(ex);
            //    transaction.Rollback();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erro genérico");
            //    Console.WriteLine(ex);
            //    transaction.Rollback();
            //}
            //finally
            //{
            //    command.Dispose();
            //    connection.Dispose();
            //}






            //try
            //{
            //    CarregarContas();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("CATCH NO METODO MAIN");
            //}

            //Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadKey();
        }



        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }



            // ---------------------------------------------

            //LeitorDeArquivo leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivo("contasl.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                // Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

            }
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
                Console.WriteLine("Código depois do throw");
            }
        }

        // numero = 1
        // divisor = 2;
    }

    class TransferenciaBancaria
    {
        private const string CONNECTION_STRING =
            @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB\ByteBank.mdf;Integrated Security=True";
        private SqlConnection connection;
        private SqlTransaction transaction;

        public void Efetuar(int contaCreditoId, int contaDebitoId, decimal valorTransferencia)
        {
            connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            transaction = connection.BeginTransaction();

            SqlCommand command = GetTransferenciaCommand
                (contaCreditoId, contaDebitoId, valorTransferencia);

            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
                Console.WriteLine("Transferência realizada com sucesso!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            finally
            {
                command.Dispose();
                transaction.Dispose();
                connection.Dispose();
            }
        }

        private SqlCommand GetTransferenciaCommand(int contaCreditoId, int contaDebitoId, decimal valorTransferencia)
        {
            SqlCommand command = new SqlCommand("p_TRANSFERENCIA_BANCARIA_i", connection, transaction);
            command.Parameters.AddWithValue("@CONTA_ID_DEBITO", contaCreditoId);
            command.Parameters.AddWithValue("@CONTA_ID_CREDITO", contaDebitoId);
            command.Parameters.AddWithValue("@VALOR", valorTransferencia);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            return command;
        }
    }
}
