using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _04.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Cliente> clientes = new List<Cliente>();
            IList<Conta> contas = new List<Conta>
            {
                new Conta(1000m, 2, 0.025m),
                new Conta(3000m, 4, 0.045m),
                new Conta(5000m, 6, 0.045m)
            };

            clientes.Add(new Cliente("José", "Silva", contas));

            Collection<Conta> contasEspeciais = new Collection<Conta>();

            foreach (Cliente cliente in clientes)
            {
                foreach (Conta conta in cliente.Contas)
                {
                    if (conta.Saldo >= 1000000m)
                    {
                        contasEspeciais.Add(conta);
                    }
                }
            }
        }
    }
}
