//Complete o código

//Você está testando um aplicativo.O aplicativo inclui métodos chamados `CalcularValorJuros` e `GravarLog`.O método `CalcularValorJuros()` calcula juros de empréstimos.O método `GravarLog()` envia mensagens de diagnóstico para uma janela do console.

//Você tem os seguintes requisitos:

//O método `CalcularValorJuros()` deve ser executado para todas as configurações de build.O método `GravarLog()` deve ser chamado apenas para compilações de depuração (debug). Você precisa garantir que os métodos sejam executados corretamente.

//Como você deveria completar o código relevante nas lacunas 1 e 2 abaixo?

//```
//private static decimal CalcularValorJuros(decimal valorEmprestimo, int prazoEmprestimo, decimal jurosDoEmprestimo)
//{
//    decimal valorJuros = valorEmprestimo * jurosDoEmprestimo * prazoEmprestimo;
//    [LACUNA 1]
//GravarLog("Valor com juros : ", valorComJuros.ToString("c"));
//    [LACUNA 2]
//    return valorJuros;
//}

//public static void GravarLog(string mensagem, string detalhe)
//{
//    Console.WriteLine("Log: {0} - {1}", mensagem, detalhe);
//}
//```


//```
//[LACUNA 1]: #if DEBUG
//[LACUNA 2]: #endif
//```

//```
//[LACUNA 1]: [Conditional("DEBUG")]
//[LACUNA 2]: [Conditional("RELEASE")]
//```

//```
//[LACUNA 1]: #region DEBUG
//[LACUNA 2]: #endregion
//```

//```
//[LACUNA 1]: #if DEBUG
//[LACUNA 2]: #endregion
//```
