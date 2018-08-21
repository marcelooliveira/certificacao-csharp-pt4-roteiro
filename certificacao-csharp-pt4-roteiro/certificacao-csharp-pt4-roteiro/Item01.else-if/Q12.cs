//Que segmento de código você deve inserir na linha 03?


//Você está desenvolvendo um aplicativo que usa vários objetos.A aplicação inclui o
//segmento de código a seguir. (Os números de linha são incluídos apenas para referência.)

//```
//01 private bool IsNull(object obj)
//02 {
//03
//04  return false;
//05 }
//```


//```
//if (null)
//{
//    return true;
//}
//```

//Incorreto.A expressão da instrução `if` entre parênteses deve ser um valor booleano.
//Correta

//```
//if (obj == 0)
//{
//    return true;
//}
//```

//Incorreto.A comparação `obj == 0` indica se o parâmetro `obj` é um valor zero, e não se ele é nulo.
//Correta

//```
//if (obj == null)
//{
//    return true;
//}
//```

//Correto.Utilize o operador `==` para comparar valores e neste caso também utilize o literal `null`.
// Correta

//```
//if (obj = null)
//{
//    return true;
//}
//```

//Incorreto.O operador `=` implica uma atribuição, e não comparação.
//Correta
