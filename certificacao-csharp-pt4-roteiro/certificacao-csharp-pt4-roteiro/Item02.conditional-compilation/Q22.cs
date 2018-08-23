//Qual código você deve usar?

//Você precisa escrever um aplicativo de console que atenda aos seguintes requisitos:
//Se o aplicativo é compilado no modo de depuração, a saída do console deve exibir "Entrando em modo debug".
//Se o aplicativo é compilado no modo Release, a saída do console deve exibir "Entrando em modo release".

//Qual código você deve usar?

//```
//#if (TRACE)
//    Console.WriteLine(""Entrando em modo debug"");
//#else
//    Console.WriteLine(""Entrando em modo release"");
//#endif


//#if (DEBUG)
//    Console.WriteLine(""Entrando em modo debug"");
//#else
//    Console.WriteLine(""Entrando em modo release""):
//#endif


//if(System.Diagnostics.Debugger.IsAttached)
//    Console.WriteLine(""Entrando em modo debug"");
//else
//    Console.WriteLine(""Entrando em modo release"");

//#region DEBUG
//    Console.WriteLine(""Entrando em modo debug"");
//#endregion
//#region RELEASE
//    Console.WriteLine(""Entrando em modo release""):
//#endregion
//```


//RESPOSTA: B

//Quando o compilador C # encontra uma diretiva # if, seguida, eventualmente, por uma diretiva #endif,
//ele irá compilar o código entre as diretivas somente se o símbolo especificado estiver definido.