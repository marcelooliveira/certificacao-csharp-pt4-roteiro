using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _03.ByteBank
{
    class RelatorioClientes
    {
        public static void ImprimirListagemClientes()
        {
            using (var leitor = new StreamReader("Clientes.txt"))
            {
                leitor.ReadLine(); // pula o cabeçalho
                Console.WriteLine($"id, nome, sobrenome, email, valor últ. empréstimo, ativo");

                string linha;
                while ((linha = leitor.ReadLine()) != null)
                {
                    var campos = linha.Split(',');
                    Console.WriteLine($"{int.Parse(campos[0])}, {campos[1]}, {campos[2]}, {campos[3]}, {decimal.Parse(campos[4])}, {campos[5]}");
                }
            }
        }
    }
}
