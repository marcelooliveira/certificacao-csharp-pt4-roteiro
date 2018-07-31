using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt4_roteiro
{
    class P06
    {
        static void Executar()
        {

        }
    }

    public class Example5
    {
        public static void Executar()
        {
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
    // The example displays the following output:
    //       Case 1





    public enum Color { Red, Green, Blue }

    public class Example2
    {
        public static void Executar()
        {
            Color c = (Color)(new Random()).Next(0, 3);
            switch (c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }
    }



    public class Example3
    {
        public static void Executar()
        {
            Color c = (Color)(new Random()).Next(0, 3);
            if (c == Color.Red)
                Console.WriteLine("The color is red");
            else if (c == Color.Green)
                Console.WriteLine("The color is green");
            else if (c == Color.Blue)
                Console.WriteLine("The color is blue");
            else
                Console.WriteLine("The color is unknown.");
        }
    }
    // The example displays the following output:
    //       The color is red




    public class Example4
    {
        public static void Executar()
        {
            Random rnd = new Random();
            int caseSwitch = rnd.Next(1, 4);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($"Case {caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"An unexpected value ({caseSwitch})");
                    break;
            }
        }
    }
    // The example displays output like the following:
    //       Case 1
}
