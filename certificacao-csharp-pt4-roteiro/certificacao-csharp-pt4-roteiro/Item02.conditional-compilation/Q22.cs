using System;

namespace Q22
{
    class Programa
    {
        public void Executar()
        {
#if (DEBUG)
            Console.WriteLine("Entrando em modo DEBUG");
#else
            Console.WriteLine("Entrando em modo RELEASE"):
#endif
        }
    }
}

//Which code should you use?

//You need to write a console application that meets the following requirements:
//If the application is compiled in Debug mode, the console output must display Entering
//debug mode.
//If the application is compiled in Release mode, the console output must display Entering
//release mode.
//Which code should you use?

//```
//#if (TRACE)
//    Console.WriteLine("Entering debug mode");
//#else
//    Console.WriteLine("Entering release mode");
//#endif


//#if (DEBUG)
//    Console.WriteLine("Entering debug mode");
//#else
//    Console.WriteLine("Entering release mode"):
//#endif


//if(System.Diagnostics.Debugger.IsAttached)
//    Console.WriteLine("Entering debug mode");
//else
//    Console.WriteLine("Entering release mode");

//#region DEBUG
//    Console.WriteLine("Entering debug mode");
//#endregion
//#region RELEASE
//    Console.WriteLine("Entering release mode"):
//#endregion
//```



//A.
//Option A

//B.
//Option B

//C.
//Option C

//D.
//Option D

//RESPOSTA: B

//Explanation:
//When the C# compiler encounters an #if directive, followed eventually by an #endif directive,
//it will compile the code between the directives only if the specified symbol is defined. Unlike
//C and C++, you cannot assign a numeric value to a symbol; the #if statement in C# is
//Boolean and only tests whether the symbol has been defined or not. For example,
//#define DEBUG
//// …
//#if DEBUG
//Console.WriteLine(“Debug version”);
//#endif
