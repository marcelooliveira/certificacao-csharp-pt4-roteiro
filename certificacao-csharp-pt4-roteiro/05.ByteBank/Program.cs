using System;

namespace _05.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimeContrato();

            Console.ReadLine();
        }

        private static void ImprimeContrato()
        {
            string titulo = "Contrato de Empréstimo";
            string corpo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            string data = $"São Paulo, " +
                $"{DateTime.Today.Day} " +
                $"de {GetMesPorExtenso(DateTime.Today.Month)} " +
                $"de {DateTime.Today.Year}";

            Console.WriteLine(titulo);
            Console.WriteLine("======================");
            Console.WriteLine(corpo);
            Console.WriteLine("======================");
            Console.WriteLine(data);
        }

        private static string GetMesPorExtenso(int mes)
        {
            string mesPorExtenso;
            switch (mes)
            {
                case 1:
                    mesPorExtenso = "Janeiro";
                    break;
                case 2:
                    mesPorExtenso = "Fevereiro";
                    break;
                case 3:
                    mesPorExtenso = "Março";
                    break;
                case 4:
                    mesPorExtenso = "Abril";
                    break;
                case 5:
                    mesPorExtenso = "Maio";
                    break;
                case 6:
                    mesPorExtenso = "Junho";
                    break;
                case 7:
                    mesPorExtenso = "Julho";
                    break;
                case 8:
                    mesPorExtenso = "Agosto";
                    break;
                case 9:
                    mesPorExtenso = "Setembro";
                    break;
                case 10:
                    mesPorExtenso = "Outubro";
                    break;
                case 11:
                    mesPorExtenso = "Novembro";
                    break;
                case 12:
                    mesPorExtenso = "Dezembro";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mes));
            }

            return mesPorExtenso;
        }
    }
}
