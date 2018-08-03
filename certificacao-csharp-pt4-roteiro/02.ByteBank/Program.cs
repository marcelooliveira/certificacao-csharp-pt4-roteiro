using System;

namespace _02.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = Emprestimo.CalcularValorComJuros(20000, 4);
            Console.WriteLine(total);

            Emprestimo emprestimo = new Emprestimo("ABC123");
            emprestimo.Finalizar();
        }
    }

    public delegate void PrazoMaximoEstouradoHandler(object source, EventArgs e);
}
