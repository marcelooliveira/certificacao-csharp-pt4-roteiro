using System;

namespace Q26
{
    class Programa
    {
        public void Executar()
        {
#if TRIAL
                AvaliarEmprestimo();
#elif BASIC
                AvaliarEmprestimo();
                ProcessarEmprestimo();
                FinanciarEmprestimo();
#else
            AvaliarEmprestimo();
            ProcessarEmprestimo();
#endif
        }

        private void FinanciarEmprestimo()
        {
            throw new NotImplementedException();
        }

        private void ProcessarEmprestimo()
        {
            throw new NotImplementedException();
        }

        private void AvaliarEmprestimo()
        {
            throw new NotImplementedException();
        }
    }
}

//Which code segment should you use?

//You are developing an application that includes methods named EvaluateLoan,
//ProcessLoan, and FundLoan. The application defines build configurations named TRIAL,
//BASIC, and ADVANCED.
//You have the following requirements:
//The TRIAL build configuration must run only the EvaluateLoan() method.
//The BASIC build configuration must run all three methods.
//The ADVANCED build configuration must run only the EvaluateLoan() and ProcessLoan() methods.
//You need to meet the requirements. Which code segment should you use?

//```
//A
//#if TRIAL
//    #warning EvaluateLoan();
//    #error ProcessLoan();
//    #error FundLoan();
//#elif ADVANCED
//    #warning EvaluateLoant);
//    #warning ProcessLoan();
//    #warning FundLoan();
//#else
//    #warning EvaluateLoan();
//    #warning ProcessLoan();
//    #error FundLoan();
//#endif

//B
//#if TRIAL
//    EvaluateLoan();
//#elif ADVANCED
//    EvaluateLoan();
//    ProcessLoan();
//    FundLoan();
//#else
//    EvaluateLoan();
//    ProcessLoan();
//#endif

//C
//#if TRIAL
//    EvaluateLoan();
//#elif BASIC
//    EvaluateLoan();
//    ProcessLoan();
//    FundLoan();
//#else
//    EvaluateLoan();
//    ProcessLoan();
//#endif


//D
//#if TRIAL
//    EvaluateLoan();
//#elif BASIC
//    EvaluateLoan();
//    ProcessLoan();
//#error FundLoan();
//#else
//    EvaluateLoan();
//    ProcessLoan();
//    FundLoan();
//#endif
//```

//A.
//Option A

//B.
//Option B

//C.
//Option C

//D.
//Option D

//# resposta 
//**C.
//Option C**