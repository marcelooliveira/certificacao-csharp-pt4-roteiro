﻿using System;
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

            ContaCorrente conta1 = new ContaCorrente(1, 100);
            ContaCorrente conta2 = new ContaCorrente(4, 50);
            Console.WriteLine(conta1);
            Console.WriteLine(conta2);

            transferencia.Efetuar(conta1, conta2, 3.5m);
            //transferencia.Efetuar(conta1, conta2, 3500000m);
            Console.WriteLine(conta1);
            Console.WriteLine(conta2);

            transferencia.Efetuar(conta2, conta1, 3.5m);
            Console.WriteLine(conta1);
            Console.WriteLine(conta2);

            Console.ReadKey();
        }
    }

    class ContaCorrente
    {
        public int Id { get; }
        public decimal Saldo { get; private set; }

        public ContaCorrente(int id, decimal saldo)
        {
            Id = id;
            Saldo = saldo;
        }

        public void Debitar(decimal valor)
        {
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
            contaDebito.Debitar(valor);
            contaCredito.Creditar(valor);
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

            comandoTaxa.ExecuteNonQuery();
            comandoTransferencia.ExecuteNonQuery();
            transaction.Commit();
            Logger.LogInfo("Transferência realizada com sucesso.");
            comandoTransferencia.Dispose();
            transaction.Dispose();
            connection.Dispose();
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
