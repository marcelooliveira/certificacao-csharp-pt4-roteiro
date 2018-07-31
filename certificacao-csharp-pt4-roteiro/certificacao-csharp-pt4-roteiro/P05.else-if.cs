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
            bool condition = true;

            if (condition)
            {
                Console.WriteLine("The variable is set to true.");
            }
            else
            {
                Console.WriteLine("The variable is set to false.");
            }








            // if-else statement  
            if (condition)
            {
                //then - statement;
            }
            else
            {  
                //else-statement;
            }
            // Next statement in the program.  

            // if statement without an else  
            if (condition)
            {
                //then - statement;
            }
            // Next statement in the program.








            // Try with m = 12 and then with m = 8.
            int m = 12;
            int n = 18;

            if (m > 10)
                if (n > 20)
                {
                    Console.WriteLine("Result1");
                }
                else
                {
                    Console.WriteLine("Result2");
                }




            // Try with m = 12 and then with m = 8.
            if (m > 10)
            {
                if (n > 20)
                    Console.WriteLine("Result1");
            }
            else
            {
                Console.WriteLine("Result2");
            }




            Console.Write("Enter a character: ");
            char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("The character is lowercase.");
                }
                else
                {
                    Console.WriteLine("The character is uppercase.");
                }
            }
            else
            {
                Console.WriteLine("The character isn't an alphabetic character.");
            }

            //Sample Output:

            //Enter a character: 2
            //The character isn't an alphabetic character.

            //Enter a character: A
            //The character is uppercase.

            //Enter a character: h
            //The character is lowercase.







            // Change the values of these variables to test the results.
            bool Condition1 = true;
            bool Condition2 = true;
            bool Condition3 = true;
            bool Condition4 = true;

            if (Condition1)
            {
                // Condition1 is true.
            }
            else if (Condition2)
            {
                // Condition1 is false and Condition2 is true.
            }
            else if (Condition3)
            {
                if (Condition4)
                {
                    // Condition1 and Condition2 are false. Condition3 and Condition4 are true.
                }
                else
                {
                    // Condition1, Condition2, and Condition4 are false. Condition3 is true.
                }
            }
            else
            {
                // Condition1, Condition2, and Condition3 are false.
            }








            Console.Write("Enter a character: ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("The character is an uppercase letter.");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("The character is a lowercase letter.");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("The character is a number.");
            }
            else
            {
                Console.WriteLine("The character is not alphanumeric.");
            }

            //Sample Input and Output:
            //Enter a character: E
            //The character is an uppercase letter.

            //Enter a character: e
            //The character is a lowercase letter.

            //Enter a character: 4
            //The character is a number.

            //Enter a character: =
            //The character is not alphanumeric.




            // NOT  
            bool result = true;
            if (!result)
            {
                Console.WriteLine("The condition is true (result is false).");
            }
            else
            {
                Console.WriteLine("The condition is false (result is true).");
            }

            // Short-circuit AND  
            int m1 = 9;
            int n1 = 7;
            int p1 = 5;
            if (m1 >= n1 && m1 >= p1)
            {
                Console.WriteLine("Nothing is larger than m.");
            }

            // AND and NOT  
            if (m1 >= n1 && !(p1 > m1))
            {
                Console.WriteLine("Nothing is larger than m.");
            }

            // Short-circuit OR  
            if (m1 > n1 || m1 > p1)
            {
                Console.WriteLine("m isn't the smallest.");
            }

            // NOT and OR  
            m1 = 4;
            if (!(m1 >= n1 || m1 >= p1))
            {
                Console.WriteLine("Now m is the smallest.");
            }
            // Output:  
            // The condition is false (result is true).  
            // Nothing is larger than m.  
            // Nothing is larger than m.  
            // m isn't the smallest.  
            // Now m is the smallest.



        }
    }
}
