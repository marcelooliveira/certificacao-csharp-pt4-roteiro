//Which two actions should you perform?

//You are modifying an application that processes leases. The following code defines the
//Lease class. (Line numbers are included for reference only.)

//```
using System;

public class Lease                                                             //01 
{                                                                              //02 
                                                                               //03 
    private int _term;                                                         //04 
    private const int MaximumTerm = 5;                                         //05 
    private const decimal Rate = 0.034m;                                       //06 
    public int Term                                                            //07 
    {                                                                          //08 
        get                                                                    //09 
        {                                                                      //10 
         return _term;                                                         //11 
        }                                                                      //12 
        set                                                                    //13 
        {                                                                      //14 
            if (value <= MaximumTerm)                                          //15 
            {                                                                  //16 
                _term = value;                                                 //17 
            }                                                                  //18 
            else                                                               //19 
            {                                                                  //20 
                                                                               //21 
            }                                                                  //22 
        }                                                                      //23 
    }                                                                          //24 
}                                                                              //25 
public delegate void MaximumTermReachedHandler(object source, EventArgs e);    //26 
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