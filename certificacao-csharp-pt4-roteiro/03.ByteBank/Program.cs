using System;

namespace _03.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = GetFatorial(5);
            System.Console.WriteLine($"fatorial: {fatorial}");
            Console.WriteLine();
            RelatorioClientes.ImprimirListagemClientes();
        }

        private static int GetFatorial(int numero)
        {
            //int contador = 1;
            //int fatorial = 1;
            //while (contador <= numero)
            //{
            //    fatorial *= contador;
            //    contador++;
            //}


            //int fatorial = 1 * 2 * 3 * 4 * 5;
            //System.Console.WriteLine($"fatorial: {fatorial}");



            //int fatorial = 1;
            //fatorial = fatorial * 1;
            //fatorial = fatorial * 2;
            //fatorial = fatorial * 3;
            //fatorial = fatorial * 4;
            //fatorial = fatorial * 5;


            //int fatorial = 1;
            //int contador = 1;
            //fatorial = fatorial * contador;
            //contador++;
            //fatorial = fatorial * contador;
            //contador++;
            //fatorial = fatorial * contador;
            //contador++;
            //fatorial = fatorial * contador;
            //contador++;
            //fatorial = fatorial * contador;
            //contador++;

            int fatorial = 1;
            int contador = 1;
            while (contador <= numero)
            {
                fatorial = fatorial * contador;
                contador++;
            }
            //System.Console.WriteLine($"fatorial: {fatorial}");

            return fatorial;
        }
    }
}
