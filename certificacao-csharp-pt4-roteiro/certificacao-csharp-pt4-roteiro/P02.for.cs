using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt4_roteiro
{
    class P02
    {
        static void Executar()
        {
            //for (initializer; condition; iterator)
            //    body

            for (int i2 = 0; i2 < 5; i2++)
            {
                Console.WriteLine(i2);
            }







            int i;
            int j = 10;
            for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}"))
            {
                // Body of the loop.
            }






            for (; ; )
            {
                // Body of the loop.
            }
        }
    }
}
