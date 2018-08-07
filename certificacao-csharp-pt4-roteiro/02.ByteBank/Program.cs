using System;

namespace _02.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = Emprestimo.CalcularJuros(20000, 4);
            Console.WriteLine(total);

            Emprestimo emprestimo = new Emprestimo("ABC123");
            emprestimo.Finalizar();
        }
    }

    public delegate void PrazoMaximoEstouradoHandler(object source, EventArgs e);

    public class MinhaClasse
    {
        public void MeuMetodo()
        {
            #if (DEBUG)
                Console.WriteLine("Versão DEBUG");
            #else
                Console.WriteLine("Versão RELEASE");
            #endif
        }
    }
}
