using System;
using System.IO;

namespace P04.Q4
{
    class Programa
    {
        public void Executar()
        {
            using (StreamReader sr = new StreamReader("log.txt"))
            {
                try
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.Write(e.ToString());
                    throw;
                }
            }
        }
    }

    class ClasseBase
    {
        public void Funcao1()
        {
            Console.WriteLine("ClasseBase.Funcao1");
        }
        public virtual void Funcao2()
        {
            Console.WriteLine("ClasseBase.Funcao2");
        }
    }

    class ClasseFilha : ClasseBase
    {
        public new void Funcao1()
        {
            Console.WriteLine("ClasseFilha.Funcao1");
        }

        public override void Funcao2()
        {
            Console.WriteLine("ClasseFilha.Funcao2");
        }
    }
}


//How should you complete the relevant code?

//DRAG DROP
//You develop an application that displays information from log files when errors occur. The
//application will prompt the user to create an error report that sends details about the error
//and the session to the administrator.
//When a user opens a log file by using the application, the application throws an exception
//and closes.
//The application must preserve the original stack trace information when an exception occurs
//during this process.
//You need to implement the method that reads the log files.
//How should you complete the relevant code? (To answer, drag the appropriate code
//segments to the correct locations in the answer area. Each code segment may be used
//once, more than once, or not at all. You may need to drag the split bar between panes or
//scroll to view content.)

//```
//opções:
//=======
//using (StringReader sr = new StringReader("log.txt"))
//using (StreamReader sr = new StringReader("log.txt"))
//throw new FileNotFoundException:
//throw;

//código:
//=======

//[LACUNA 1]
//{
//    try
//    {
//        string line;
//        while ((line = sr.ReadLine()) != null)
//        {
//            Console.WriteLine(line);
//        )
//    }
//    catch (FileNotFoundException e)
//    {
//        Console.Write(e.ToString());
//        [LACUNA 2]
//    )
//)
//```

//![](https://cdn.briefmenow.org/wp-content/uploads/70-483-v2/33.jpg)

