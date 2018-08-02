using System;

class Program
{
    public void Executar()
    {
        try
        {

        }
        catch (Exception ex)
        {
            ExceptionLogger.LogException(ex);
            throw;
        }
    }
}

class ExceptionLogger
{
    internal static void LogException(Exception ex)
    {
        throw new NotImplementedException();
    }
}

//Which code segment should you use?

//You are developing an application that uses structured exception handling. The application
//includes a class named ExceptionLogger.
//The ExceptionLogger class implements a method named LogException by using the
//following code segment:
//public static void LogException(Exception ex)

//You have the following requirements:
//Log all exceptions by using the LogException() method of the ExceptionLogger class.
//Rethrow the original exception, including the entire exception stack.
//You need to meet the requirements.
//Which code segment should you use?

//```
//A
//catch (Exception ex)
//{
//    ExceptionLogger.LogException(ex);
//    throw;
//}

//B
//catch (Exception ex)
//{
//    ExceptionLogger.LogException(ex);
//    throw ex;
//}

//C
//catch
//{
//    ExceptionLogger.LogException(new Exception());
//    throw;
//}

//D
//catch
//{
//    var ex = new Exception();
//    throw ex;
//}
//```

//#RESPOSTA

//A.
//Option A