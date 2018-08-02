using System;
using System.IO;

namespace Q24
{
    class Programa
    {
        public void Executar()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\console.txt"))
            {
                Console.SetOut(writer);
                using (FileStream stream = new FileStream(@"C:\file.txt", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream) Console.WriteLine(reader.ReadLine());
                }
            }
        }
    }
    }
}

//complete each statement according to the information presented in the code.

//```
//using (StreamWriter writer = new StreamWriter(@"C:\console.txt"))
//{
//    Console.SetOut(writer}:
//    using (FileStream stream = new FileStream(@"C:\file.txt", FileMode.Open))
//    {
//        using (StreamReader reader = new StreamReader(stream))
//        {
//            while (!reader.EndOfStream) Console.WriteLine(reader.ReadLine());
//        }
//    }
//}
//```

//To answer, complete each statement according to the information presented in the code.

//```
//If File.txt does NOT exist in the root of C:, will be thrown:
//ArgumentNullException
//FileLoadException
//FileNotFoundException
//PipeException

//The final output of the streaming operation will be:
//a console window
//the Console.txt file
//the file.txt file
//the Visual Studio Debug console
//```


//**RESPOSTA:**


//If File.txt does NOT exist in the root of C:, will be thrown:
//**FileNotFoundException**

//The final output of the streaming operation will be:
//**the Console.txt file**

