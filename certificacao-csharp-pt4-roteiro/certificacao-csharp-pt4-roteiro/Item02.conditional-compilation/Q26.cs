//Qual segmento de código você deve usar?

//Você está desenvolvendo um aplicativo que inclui métodos denominados `Emprestimo`,
//`ProcessarEmprestimo` e `FinanciarEmprestimo`. O aplicativo define as configurações de construção denominadas TRIAL,
//BÁSICO e AVANÇADO.
//Você tem os seguintes requisitos:

//* A configuração de compilação do TRIAL deve executar apenas o método `Emprestimo()`.
//* A configuração de compilação do BASIC deve executar todos os três métodos.
//* A configuração de construção ADVANCED deve executar apenas os métodos `Emprestimo()` e `ProcessarEmprestimo()`.

//Você precisa atender aos requisitos. Qual segmento de código você deve usar?

//```
//A
//#if TRIAL
//    #warning AvaliarEmprestimo();
//    #error ProcessarEmprestimo();
//    #error FinanciarEmprestimo();
//#elif ADVANCED
//    #warning AvaliarEmprestimo();
//    #warning ProcessarEmprestimo();
//    #warning FinanciarEmprestimo();
//#else
//    #warning AvaliarEmprestimo();
//    #warning ProcessarEmprestimo();
//    #error FinanciarEmprestimo();
//#endif

//B
//#if TRIAL
//    AvaliarEmprestimo();
//#elif ADVANCED
//    AvaliarEmprestimo();
//    ProcessarEmprestimo();
//    FinanciarEmprestimo();
//#else
//    AvaliarEmprestimo();
//    ProcessarEmprestimo();
//#endif

//C
//#if TRIAL
//    AvaliarEmprestimo();
//#elif BASIC
//    AvaliarEmprestimo();
//    ProcessarEmprestimo();
//    FinanciarEmprestimo();
//#else
//    AvaliarEmprestimo();
//    ProcessarEmprestimo();
//#endif


//D
//#if TRIAL
//    AvaliarEmprestimo();
//#elif BASIC
//    AvaliarEmprestimo();
//    ProcessarEmprestimo();
//#error FinanciarEmprestimo();
//#else
//    AvaliarEmprestimo();
//    ProcessarEmprestimo();
//    FinanciarEmprestimo();
//#endif
//```
