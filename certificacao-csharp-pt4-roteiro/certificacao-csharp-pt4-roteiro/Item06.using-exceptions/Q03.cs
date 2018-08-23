//Qual segmento de código você deve usar?

//Você está desenvolvendo um aplicativo que usa manipulação de exceção estruturada.

//O aplicativo inclui uma classe chamada `Logger`.

//A classe `Logger` implementa um método chamado `Logger` usando o segmento de código a seguir:

//```
//public static void LogError(Exceção ex)
//```

//Você tem os seguintes requisitos:

//* Você deve registrar todas as exceções usando o método `LogError()` da classe `Logger`.
//* Lance novamente a exceção original, incluindo toda a pilha de exceções.

//Qual segmento de código você deve usar?

//```
//A
//catch (Exception ex)
//{
//    Logger.LogError(ex);
//    throw;
//}

//B
//catch (Exception ex)
//{
//    Logger.LogError(ex);
//    throw ex;
//}

//C
//catch
//{
//    Logger.LogError(new Exception());
//    throw;
//}

//D
//catch
//{
//    var ex = new Exception();
//    throw ex;
//}
