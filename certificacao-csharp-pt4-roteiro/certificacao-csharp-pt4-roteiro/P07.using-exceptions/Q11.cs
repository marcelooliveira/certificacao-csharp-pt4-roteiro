using System;

namespace Q11
{
    class Programa
    {
        public void Executar()
        {
            try
            {
                DoWork();
            }
            catch (CaelumValidationException ex)
            {
                Log(ex);
            }
            catch (CaelumException ex)
            {
                Log(ex);
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private void Log(Exception ex)
        {
            throw new NotImplementedException();
        }

        private void DoWork()
        {
            throw new NotImplementedException();
        }
    }

    public class CaelumException : Exception { }
    public class CaelumDbException : CaelumException { }
    public class CaelumValidationException : CaelumException { }
}

//How should you complete the relevant code?

//DRAG DROP
//You are developing an application that implements a set of custom exception types. You
//declare the custom exception types by using the following code segments:

//```
//public class CaelumException : System.Exception { ... }
//public class CaelumDbException : CaelumException { ... }
//public class CaelumValidationException : CaelumException { ... }
//```

//The application includes a function named DoWork that throws .NET Framework exceptions
//and custom exceptions.
//The application contains only the following logging methods:

//```
//static void Log(Exception ex) { ... }
//static void Log(CaelumException ex) { ... }
//static void Log(CaelumValidationException ex) { ... }
//```

//The application must meet the following requirements:
//When CaelumValidationException exceptions are caught, log the information by
//using the static void Log (CaelumValidationException ex) method.
//When CaelumDbException or other CaelumException exceptions are
//caught, log the information by using the static void I oq( CaelumException ex)
//method.
//You need to meet the requirements.
//How should you complete the relevant code? (To answer, drag the appropriate code
//segments to the correct locations in the answer area. Each code segment may be used
//once, more than once, or not at all. You may need to drag the split bar between panes or
//scroll to view content.)

//```
//(Exception ex)
//(CaelumException ex)
//(CaelumValidationException ex)
//(CaelumException ex)
//```

//```
//try
//{
//    DoWork();
//}
//catch [LACUNA 1]
//{
//    Log(ex);
//}
//catch [LACUNA 2]
//{
//    Log(ex);
//}
//catch [LACUNA 3]
//{
//    Log(ex);
//}
//```

//# resposta


//```
//(CaelumValidationException ex)
//(CaelumException ex)
//(Exception ex)
//```

