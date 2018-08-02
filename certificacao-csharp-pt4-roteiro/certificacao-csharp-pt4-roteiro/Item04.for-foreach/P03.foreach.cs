using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt4_roteiro
{
    class P03
    {
        static void Executar()
        {
            var fibonacci = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            int count = 0;
            foreach (int element in fibonacci)
            {
                count++;
                Console.WriteLine($"Elemento No.{count}: {element}");
            }
            Console.WriteLine($"Número de elementos: {count}");

        }
    }
}
