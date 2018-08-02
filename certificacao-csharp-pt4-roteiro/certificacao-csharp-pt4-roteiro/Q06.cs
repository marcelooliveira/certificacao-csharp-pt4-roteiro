using System;

namespace Q06
{
    class Programa
    {
        public void Executar()
        {

        }

        private static decimal CalculateInterest(decimal loanAmount, int loanTerm, decimal loanRate)
        {
            decimal interestAmount = loanAmount * loanRate * loanTerm;
            #if DEBUG
            LogLine("Interest Amount : ", interestAmount.ToString("c"));
            #endif
            return interestAmount;
        }

        public static void LogLine(string message, string detail)
        {
            Console.WriteLine("Log: {0} - {1}", message, detail);
        }
    }
}

//How should you complete the relevant code?

//DRAG DROP
//You are testing an application. The application includes methods named CalculateInterest
//and LogLine. The CalculateInterest() method calculates loan interest. The LogLine() method
//sends diagnostic messages to a console window.
//You have the following requirements:
//The CalculateInterest() method must run for all build configurations.
//The LogLine() method must be called only for debug builds.
//You need to ensure that the methods run correctly.
//How should you complete the relevant code? (To answer, drag the appropriate code
//segments to the correct locations in the answer area. Each code segment may be used
//once, more than once, or not at all. You may need to drag the split bar between panes or
//scroll to view content.)

//OPÇÕES:

//```
//[Conditional("DEBUG")}
//[Conditional("RELEASE")]
//#if DEBUG
//#region DEBUG
//#endif
//#endregion
//```


//```
//private static decimal CalculateInterest(decimal loanAmount, int loanTerm, decimal loanRate)
//(
//    decimal interestAmount = loanAmount * loanRate * loanTerm;
//    [LACUNA 1] 
//    LogLine("Interest Amount : ", interestAmount.ToString("c"));
//    [LACUNA 2] 
//    return interestAmount;
//)
//public static void LogLine(string message, string detail)
//(
//    Console.WriteLine("Log: {0} - {1}", message, detail);
//)
//```

//# resposta
//```
//[LACUNA 1] #if DEBUG
//[LACUNA 2] #endif
//```