using System;

namespace Q25
{
    class Programa
    {
        public void Executar()
        {
            try
            {

            }
            //catch(DivideByZeroException e) {Console.WriteLine("Divide by zero");}
            catch (ArithmeticException e) { Console.WriteLine("Arithmetic error"); }
            catch (ArgumentException e) { Console.WriteLine("Bad Argument"); }
            catch (Exception e) { Console.WriteLine("General error"); }
        }
    }
}

//You need to add the following code to the method: At which line should you insert the code?

//You are developing an application in C#.
//The application uses exception handling on a method that is used to execute mathematical
//calculations by using integer numbers.
//You write the following catch blocks for the method (line numbers are included for reference only):

//```
//catch(ArithmeticException e) {Console.WriteLine("Arithmetic error");}
//catch(ArgumentException e) {Console.WriteLine("Bad Argument");}
//catch(Exception e) {Console.WriteLine("General error");}
//```

//You need to add the following code to the method:

//```
//catch(DivideByZeroException e) {Console.WriteLine("Divide by zero");}
//```

//At which line should you insert the code?

//A.
//01

//B.
//03

//C.
//05

//D.
//07

//# RESPOSTA: A