//Você está desenvolvendo um aplicativo que implementa um conjunto de tipos de exceção personalizados.
//Você declara os tipos de exceção customizada usando os seguintes segmentos de código:

//```
//public class AluraException : System.Exception { ... }
//public class AluraDbException : AluraException { ... }
//public class AluraValidationException : AluraException { ... }
//```

//O aplicativo inclui uma função chamada `FaçaAlgo`, que lança exceções do .NET Framework e exceções personalizadas.
//O aplicativo contém apenas os seguintes métodos de log:

//```
//static void Log(Exception ex) { ... }
//static void Log(AluraException ex) { ... }
//static void Log(AluraValidationException ex) { ... }
//```

//O aplicativo deve atender aos seguintes requisitos:

//* Quando as exceções `AluraValidationException` são capturadas, registre as informações usando o método estático `void Log(AluraValidationException ex)`.
//* Quando `AluraDbException` ou outras exceções `AluraException` são capturadas, registre o log das informações usando o método `static void Log(AluraException ex)`.

//Como você substituiria as lacunas no fragmento de código abaixo para atender a esses requisitos?


//```
//try
//{
//    FacaAlgo();
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

//```
//[LACUNA 1]: (AluraValidationException ex)
//[LACUNA 2]: (AluraException ex)
//[LACUNA 3]: (Exception ex)
//```

