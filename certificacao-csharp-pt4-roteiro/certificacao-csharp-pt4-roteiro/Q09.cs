using System;

namespace Q09
{
    class Programa
    {
        public void Executar()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                throw;
            }
        }

    }

    class Logger
    {
        public static void Log(Exception ex) { }
    }
}

//Which code segment should you use?

//You are developing an application that uses structured exception handling. The application
//includes a class named Logger. The Logger class implements a method named Log by
//using the following code segment:
//public static void Log(Exception ex) { }

//You have the following requirements:
//Log all exceptions by using the Log() method of the Logger class.
//Rethrow the original exception, including the entire exception stack.
//You need to meet the requirements. Which code segment should you use?

//```
//A
//catch
//{
//    var ex = new Exception();
//    throw ex;
//}

//B
//catch (Exception ex)
//{
//    Logger.Log(ex);
//    throw ex;
//}

//C
//catch
//{
//    Logger.Log(new Exception());
//    throw;
//}

//D
//catch (Exception ex)
//{
//    Logger.Log(ex);
//    throw;
//}
//```

//# RESPOSTA

//D.
//Option D