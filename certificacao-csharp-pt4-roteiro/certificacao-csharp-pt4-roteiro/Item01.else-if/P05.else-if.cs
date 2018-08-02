using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt4_roteiro
{
    class P05
    {
        static void Executar()
        {
            bool condicao = true;

            if (condicao)
            {
                Console.WriteLine("A variável foi definida como verdadeiro.");
            }
            else
            {
                Console.WriteLine("A variável foi definida como falso.");
            }








            // instrução if-else  
            if (condicao)
            {
                //instrução then;
            }
            else
            {
                //instrução else;
            }
            // Próxima instrução do programa. 

            // instrução if sem um else  
            if (condicao)
            {
                //instrução then;
            }
            // Próxima instrução do programa. 








            // Tenta com m = 12 e depois com m = 8
            int m = 12;
            int n = 18;

            if (m > 10)
                if (n > 20)
                {
                    Console.WriteLine("Resultado 1");
                }
                else
                {
                    Console.WriteLine("Resultado 2");
                }




            // Tenta com m = 12 e depois com m = 8
            if (m > 10)
            {
                if (n > 20)
                    Console.WriteLine("Result1");
            }
            else
            {
                Console.WriteLine("Result2");
            }




            Console.Write("Digite um caractere: ");
            char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("O caractere é minúsculo.");
                }
                else
                {
                    Console.WriteLine("O caractere é maiúsculo.");
                }
            }
            else
            {
                Console.WriteLine("O caractere não é alfabético.");
            }

            //Saída:

            //Digite um caractere: 2
            //O caractere não é alfabético.

            //Digite um caractere: A
            //O caractere é maiúsculo.

            //Digite um caractere: h
            //O caractere é minúsculo.







            // Change the values of these variables to test the results.
            bool Condicao1 = true;
            bool Condicao2 = true;
            bool Condicao3 = true;
            bool Condicao4 = true;

            if (Condicao1)
            {
                // Condicao1 é verdadeira.
            }
            else if (Condicao2)
            {
                // Condicao1 é falsa e Condicao2 é verdadeira.
            }
            else if (Condicao3)
            {
                if (Condicao4)
                {
                    // Condicao1 e Condicao2 são falsas. Condicao3 e Condicao4 são verdadeiras.
                }
                else
                {
                    // Condicao1, Condicao2, e Condition4 são falsas. Condicao3 é verdadeira.
                }
            }
            else
            {
                // Condition1, Condition2, and Condition3 are false.
            }








            Console.Write("Digite um caractere: ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("O caractere é maiúsculo.");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("O caractere é minúsculo.");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("O caractere é um número.");
            }
            else
            {
                Console.WriteLine("O caractere não é alfanumérico.");
            }




            //Saída
            //=====
            //Digite um caractere: E
            //O caractere é maiúsculo

            //Digite um caractere: e
            //O caractere é minúsculo

            //Digite um caractere: 4
            //O caractere é um número

            //Digite um caractere: =
            //O caractere não é alfanumérico




            // NOT  
            bool resultado = true;
            if (!resultado)
            {
                Console.WriteLine("A condição é verdadeira (resultado é falso).");
            }
            else
            {
                Console.WriteLine("A condição é falsa (resultado é verdadeiro).");
            }

            // AND curto-circuito
            int m1 = 9;
            int n1 = 7;
            int p1 = 5;
            if (m1 >= n1 && m1 >= p1)
            {
                Console.WriteLine("Nada é maior que m.");
            }

            // AND e NOT
            if (m1 >= n1 && !(p1 > m1))
            {
                Console.WriteLine("Nada é maior que m.");
            }

            // OR curto-circuito
            if (m1 > n1 || m1 > p1)
            {
                Console.WriteLine("m não é o menor.");
            }

            // NOT e OR  
            m1 = 4;
            if (!(m1 >= n1 || m1 >= p1))
            {
                Console.WriteLine("agora me é o menor.");
            }
        }
    }
}
