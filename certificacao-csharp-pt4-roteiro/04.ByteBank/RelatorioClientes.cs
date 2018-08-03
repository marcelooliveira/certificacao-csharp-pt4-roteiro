using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _04.ByteBank
{
    class RelatorioClientes
    {
        public static void ImprimirListagemClientes()
        {
            List<Cliente> clientes = GetClientes();

            Console.WriteLine($"id, nome, sobrenome, email, valor últ. empréstimo");

            //for (int i = 0; i < clientes.Count; i++)
            //{
            //    var cliente = clientes[i];
            //    Console.WriteLine($"{cliente.Id}, {cliente.Nome}, {cliente.Sobrenome}, {cliente.Email}, {cliente.ValorUltimoEmprestimo}");
            //}

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"{cliente.Id}, {cliente.Nome}, {cliente.Sobrenome}, {cliente.Email}, {cliente.ValorUltimoEmprestimo}");
            }
        }

        private static List<Cliente> GetClientes()
        {
            var clientes = new List<Cliente>();
            using (var leitor = new StreamReader("Clientes.txt"))
            {
                leitor.ReadLine(); // pula o cabeçalho
                string linha;
                while ((linha = leitor.ReadLine()) != null)
                {
                    var campos = linha.Split(',');
                    clientes.Add(new Cliente(int.Parse(campos[0]), campos[1], campos[2], campos[3], decimal.Parse(campos[4])));
                }
            }

            return clientes;
        }
    }
}
