using System;

namespace Q05
{
    class Programa
    {
        public void Executar()
        {
            try
            {
                DoWork();
            }
            catch (AluraValidationException ex)
            {
                Log(ex);
            }
            catch (AluraException ex)
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

    public class AluraException : Exception {  }
    public class AluraDbException : AluraException {  }
    public class AluraValidationException : AluraException {  }
}

//How should you complete the relevant code?

//DRAG DROP
//You are developing an application that implements a set of custom exception types. You
//declare the custom exception types by using the following code segments:

//```
//public class AluraException : System.Exception { ... }
//public class AluraDbException : AluraException { ... }
//public class AluraValidationException : AluraException { ... }
//```

//The application includes a function named DoWork that throws .NET Framework exceptions
//and custom exceptions.
//The application contains only the following logging methods:

//```
//static void Log(Exception ex) { ... }
//static void Log(AluraException ex) { ... }
//static void Log(AluraValidationException ex) { ... }
//```

//The application must meet the following requirements:
//When AluraValidationException exceptions are caught, log the information by
//using the static void Log (AluraValidationException ex) method.
//When AluraDbException or other AluraException exceptions are
//caught, log the information by using the static void I oq( AluraException ex)
//method.
//You need to meet the requirements.
//How should you complete the relevant code? (To answer, drag the appropriate code
//segments to the correct locations in the answer area. Each code segment may be used
//once, more than once, or not at all. You may need to drag the split bar between panes or
//scroll to view content.)

//```
//(Exception ex)
//(AluraException ex)
//(AluraValidationException ex)
//(AluraException ex)
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
//(AluraValidationException ex)
//(AluraException ex)
//(Exception ex)
//```

