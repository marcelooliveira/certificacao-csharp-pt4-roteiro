using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ByteBank
{
    enum StatusCliente
    {
        Ativo,
        Inativo,
        Novo
    }

    class Cliente
    {
        public Cliente(int id, string nome, string sobrenome, string email, decimal valorUltimoEmprestimo, StatusCliente status)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            ValorUltimoEmprestimo = valorUltimoEmprestimo;
            Status = status;
        }

        public Cliente(int id, string nome, string sobrenome, string email, decimal valorUltimoEmprestimo)
            : this(id, nome, sobrenome, email, valorUltimoEmprestimo, StatusCliente.Novo)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            ValorUltimoEmprestimo = valorUltimoEmprestimo;
        }

        public Cliente(string nome, string sobrenome, IList<Conta> contas)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Contas = contas;
        }

        public Cliente(int id, string nome, string sobrenome, string email, decimal valorUltimoEmprestimo, IList<Conta> contas)
            : this(id, nome, sobrenome, email, valorUltimoEmprestimo, StatusCliente.Novo)
        {
            Contas = contas;
        }

        public int Id { get; }
        public string Nome { get; }
        public string Sobrenome { get; }
        public string Email { get; }
        public decimal ValorUltimoEmprestimo { get; }
        public IList<Conta> Contas { get; } = new List<Conta>();
        public StatusCliente Status { get; } = StatusCliente.Ativo;
    }
}
