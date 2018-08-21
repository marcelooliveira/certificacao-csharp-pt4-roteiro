//Você está desenvolvendo um módulo de empréstimos para o banco ByteBank.
//Você precisa ajustar o valor do empréstimo para atender os requisitos.
//O método abaixo existe para calcular o valor dos juros a partir do valor do empréstimo solicitado, e o prazo para pagamento.
//(As linhas abaixo são incluídas apenas para referência.)

//```
//01   private static decimal CalcularValorDosJuros(decimal valorEmprestimo, int prazoEmprestimo)
//02   {
//03       decimal valorJuros;
//04       decimal jurosDoEmprestimo;
//05       if (prazoEmprestimo > 0 && prazoEmprestimo< 5 && valorEmprestimo< 5000m)
//06       {
//07           jurosDoEmprestimo = 0.045m;
//08       }
//09       else if (prazoEmprestimo > 5 && valorEmprestimo > 5000m)
//10       {
//11           jurosDoEmprestimo = 0.085m;
//12       }
//13       else
//14       {
//15           jurosDoEmprestimo = 0.055m; //jurosDoEmprestimo = 0.0825m;
//16       }
//17       valorJuros = valorEmprestimo* jurosDoEmprestimo * prazoEmprestimo;
//18       return valorJuros;
//19   }
//```

//Quando o `prazoEmprestimo` for 3 e o `valorEmprestimo` for 9750, valor de `jurosDoEmprestimo`
//deve ser definido como 8,25%. Você precisa ajustar o valor do `jurosDoEmprestimo` para atender os requisitos.
//O que você deve fazer?

//Susbtitua a linha 04 pelo seguinte segmento de código:

//decimal jurosDoEmprestimo = 0.0325m;

//Incorreto.O valor de jurosDoEmprestimo sempre será sobrescrito por alguma outra atribuição posterior no método.

//Alternativa correta
//Susbtitua a linha 17 pelo seguinte segmento de código:


//valorJuros = valorEmprestimo * 0.0825m * prazoEmprestimo;

//Incorreto.Isso fixará os juros do empréstimo em 8,25%, não importando quais os parâmetros recebidos.

//Alternativa correta
//Susbtitua a linha 15 pelo seguinte segmento de código:


//jurosDoEmprestimo = 0.0825m;

//Correto.Quando o prazoEmprestimo for 3 e o valorEmprestimo for 9750, essa linha será executada e é nesse ponto em que o jurosDoEmprestimo deve ser definido como 0.0825m, que é o mesmo que 8,25%.

//Alternativa correta
//Susbtitua a linha 07 pelo seguinte segmento de código:

//jurosDoEmprestimo = 0.0825m;
 
//Incorreto.Quando o prazoEmprestimo for 3 e o valorEmprestimo for 9750, o programa não executará a linha 07, porque a instrução if será avaliada como false.