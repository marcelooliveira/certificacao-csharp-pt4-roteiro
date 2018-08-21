//Quais duas ações você deve tomar?

//Você está modificando uma aplicação que processa _empréstimos_.O código seguinte defines
//a classe `Emprestimo`. (Números de linhas foram incluídos apenas para referência).

//```
//01    public class Emprestimo
//02    {
//03
//04        private int prazo;
//05        private const int PRAZO_MAXIMO_PAGAMENTO_ANOS = 5;
//06        private const decimal JUROS = 0.034m;
//07        public int Prazo
//08        {
//09            get
//10            {
//11                return prazo;
//12            }
//13            set
//14            {
//15                if (value <= PRAZO_MAXIMO_PAGAMENTO_ANOS)
//16                {
//17                    prazo = value;
//18                }
//19                else
//20                {
//21
//22                }
//23            }
//24        }
//25    }
//26
//27    public delegate void PrazoMaximoEstouradoHandler(object source, EventArgs e);
//```

//Os empréstimos devem ser restringidos a um período máximo de pagamento de 5 anos.A aplicação
//deve enviar uma mensagem de notificação se uma solicitação de empréstimo exceder o período de 5 anos.

//Você precisa implementar o mecanismo de notificação.Quais duas ações você deveria tomar? (Cada
//resposta correta apresenta parte da solução.Escolha duas.)

//Insira o seguinte segmento de código na linha 21:

//```
//if (OnPrazoMaximoEstourado != null)
//{
//    OnPrazoMaximoEstourado(this, new EventArgs());
//}
//```

//Isso mesmo.A condição `if (OnPrazoMaximoEstourado != null)` impede que o evento não assinado seja chamado na linha seguinte, prevenindo assim um erro de `NullReferenceException`.
// Correta

//Insira o seguinte segmento de código na linha 03:
//```
//private string PrazoMaximoEstouradoEvent;
//```

//Incorreto.Um campo string não teria utilidade nesse cenário.
//Correta


//Insira o seguinte segmento de código na linha 03:

//```
//public string PrazoMaximoEstouradoEvent { get; set; }
//```

//Incorreto.Uma propriedade string não teria utilidade nesse cenário.
//Correta


//Insira o seguinte código na linha 03:

//```
//public event PrazoMaximoEstouradoHandler OnPrazoMaximoEstourado;
//```

//Isso mesmo.Precisamos declarar um evento na classe antes de invocá-lo.
// Correta

//Insira o seguinte segmento de código na linha 21:
//```
//value = 4;
//```

//Incorreto.As regras de negócio não dizem que o prazo seja definido como 4 caso o valor atribuído à propriedade estoure o prazo máximo.
//Correta


//Insira o seguinte segmento de código na linha 21:

//```
//value = PRAZO_MAXIMO_PAGAMENTO_ANOS;
//```

//Incorreto.As regras de negócio não dizem que o prazo seja definido com o valor do prazo máximo, caso o valor atribuído à propriedade estoure o prazo máximo.
//Correta
