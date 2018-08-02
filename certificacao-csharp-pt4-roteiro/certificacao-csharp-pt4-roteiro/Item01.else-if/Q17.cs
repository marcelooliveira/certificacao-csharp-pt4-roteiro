using System;

namespace Q17
{
    class Programa
    {
        public void Executar()
        {

        }

    }

    public class Loan
    {
        private int prazo;
        private const int PRAZO_MAXIMO_ANOS = 10;
        private const decimal JUROS = 0.034m;
        public int Prazo
        {
            get
            {
                return prazo;
            }
            set
            {
                if (value <= PRAZO_MAXIMO_ANOS)
                {
                    prazo = value;
                }
                else
                {

                }
            }
        }
        public delegate void MaximumTermReachedHandler(object source, EventArgs e);
    }
}
//Which two actions should you perform?

//You are modifying an application that processes loans. The following code defines the Loan
//class. (Line numbers are included for reference only.)

//```
//01    public class Loan
//02    {
//03    
//04       private int _term;
//05        private const int MaximumTerm = 10;
//06        private const decimal Rate = 0.034m;
//07        public int Term
//08        {
//09        get
//10        {
//11            return _term;
//12        }
//13        set
//14        {
//15            if (value <= MaximumTerm)
//16        {
//17            _term = value;
//18        }
//19        else
//20        {
//21
//22        }
//23    }
//24    public delegate void MaximumTermReachedHandler(object source, EventArgs e);
//```

//Loans are restricted to a maximum term of 10 years. The application must send a notification
//message if a loan request exceeds 10 years.
//You need to implement the notification mechanism.
//Which two actions should you perform? (Each correct answer presents part of the solution.
//Choose two.)

//```
//Insert the following code segment at line 03:
//public string MaximumTermReachedEvent { get; set: }

//Insert the following code segment at line 21:
//if [OnMaximumTermReached != null)
//{
//    OnMaximumTermReached(this, new EventArgs());
//}

//Insert the following code segment at line 03:
//private string MaximumTermReachedEvent;

//Insert the following code segment at line 03:
//public event MaximumTermReachedHandler OnMaximumTermReached;

//Insert the following code segment at line 21:
//value = MaximumTerm;

//Insert the following code segment at line 21:
//value = 9;
//```

//B.
//Option B

//D.
//Option D

//Explanation:
//B: Raise the event.
//D: Declare the event handler.
