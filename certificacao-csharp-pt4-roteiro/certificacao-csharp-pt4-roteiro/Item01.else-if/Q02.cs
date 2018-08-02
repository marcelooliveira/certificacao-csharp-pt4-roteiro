//Which two actions should you perform?

//You are modifying an application that processes leases. The following code defines the
//Lease class. (Line numbers are included for reference only.)

//```
using System;

public class Arrendamento
{

    private int prazo;
    private const int PRAZO_MAXIMO_ANOS = 5;
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
}
public delegate void MaximumTermReachedHandler(object source, EventArgs e);
//```

//Leases are restricted to a maximum term of 5 years. The application must send a notification
//message if a lease request exceeds 5 years.
//You need to implement the notification mechanism.
//Which two actions should you perform? (Each correct answer presents part of the solution.
//Choose two.)

//```
//A. Insert the following code segment at line 03:
//public event MaximumTermReachedHandler OnMaximumTermReached;

//B. Insert the following code segment at line 21:
//if (OnMaximumTermReached != null)
//{
//    OnMaximumTermReached(this, new EventArgs () ):
//}

//C. Insert the following code segment at line 21:
//value = MaximumTerm;

//D. Insert the following code segment at line 03:
//public string MaximumTermReachedEvent { get; set; }

//E. Insert the following code segment at line 03:
//private string MaximumTermReachedEvent;

//F. Insert the following code segment at line 21:
//value = 4;
//```

//# RESPOSTAS:

//A.Option A

//B.Option B