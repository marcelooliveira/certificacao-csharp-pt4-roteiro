using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ByteBank
{
    class Cliente
    {
        public Cliente(int id, string nome, string sobrenome, string email, decimal valorUltimoEmprestimo, bool ativo)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            ValorUltimoEmprestimo = valorUltimoEmprestimo;
            Ativo = ativo;
        }

        public Cliente(string nome, string sobrenome, IList<Conta> contas)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Contas = contas;
        }

        public Cliente(int id, string nome, string sobrenome, string email, decimal valorUltimoEmprestimo, IList<Conta> contas)
            : this(id, nome, sobrenome, email, valorUltimoEmprestimo, true)
        {
            Contas = contas;
        }

        public int Id { get; }
        public string Nome { get; }
        public string Sobrenome { get; }
        public string Email { get; }
        public decimal ValorUltimoEmprestimo { get; }
        public IList<Conta> Contas { get; } = new List<Conta>();
        public bool Ativo { get; } = true;
    }
}
