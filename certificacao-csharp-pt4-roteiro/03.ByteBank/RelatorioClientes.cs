using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _03.ByteBank
{
    class RelatorioClientes
    {
        //public static void ImprimirListagemClientes()
        //{
        //    using (var leitor = new StreamReader("Clientes.txt"))
        //    {
        //        // lê o cabeçalho
        //        string linha = leitor.ReadLine();
        //        Console.WriteLine(linha); //imprime cabeçalho

        //        //lê primeira linha de dados
        //        linha = leitor.ReadLine();
        //        //verifica fim de arquivo
        //        if (linha == null) { return; }

        //        //imprime a primeira linha de dados
        //        var campos = linha.Split(',');
        //        Console.WriteLine(
        //            $"{int.Parse(campos[0])}, {campos[1]}" +
        //            $", {campos[2]}, {campos[3]}" +
        //            $", {decimal.Parse(campos[4])}, {campos[5]}");
        //    }
        //}

        public static void ImprimirListagemClientes()
        {
            using (var leitor = new StreamReader("Clientes.txt"))
            {
                // lê o cabeçalho
                string linha = leitor.ReadLine();
                Console.WriteLine(linha); //imprime cabeçalho

                //lê primeira linha de dados e verifica fim de arquivo
                while ((linha = leitor.ReadLine()) != null)
                {
                    //imprime a primeira linha de dados
                    var campos = linha.Split(',');
                    Console.WriteLine(
                        $"{int.Parse(campos[0])}, {campos[1]}" +
                        $", {campos[2]}, {campos[3]}" +
                        $", {decimal.Parse(campos[4])}, {campos[5]}"); 
                }
            }
        }
    }
}
