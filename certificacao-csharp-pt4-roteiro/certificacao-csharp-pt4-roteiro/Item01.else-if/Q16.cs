namespace Q16
{
    class Programa
    {
        public void Executar()
        {

        }

        private static decimal CalcularValorComJuros(decimal valorEmprestimo, int prazoEmprestimo)
        {
            decimal valorComJuros;
            decimal jurosDoEmprestimo;
            if (prazoEmprestimo > 0 && prazoEmprestimo < 5 && valorEmprestimo < 5000m)
            {
                jurosDoEmprestimo = 0.045m;
            }
            else if (prazoEmprestimo > 5 && valorEmprestimo > 5000m)
            {
                jurosDoEmprestimo = 0.085m;
            }
            else
            {
                jurosDoEmprestimo = 0.055m; //jurosDoEmprestimo = 0.0825m;
            }
            valorComJuros = valorEmprestimo * jurosDoEmprestimo * prazoEmprestimo;
            return valorComJuros;
        }
    }
}

//You need to adjust the loanRate value to meet the requirements

//You are evaluating a method that calculates loan interest- The application includes the
//following code segment. (Line numbers are included for reference only.)

//```
//01  private static decimal CalculateInterest(decimal loanAmount, int loanTerm)
//02  {
//03      decimal interestAmount;
//04      decimal loanRate;
//05      if (loanTerm > 0 && loanTerm < 5 && loanAmount < 5000m)
//06      {
//07          loanRate = 0.045m;
//08      }
//09      else if (loanTerm > 5 && loanAmount > 5000m)
//10      {
//11          loanRate = 0.085m;
//12      }
//13      else
//14      {
//15          loanRate = 0.0825m; //loanRate = 0.055m;
//16      }
//17      interestAmount = loanAmount * loanRate * loanTerm;
//18      return interestAmount;
//19  }
//```

//When the loanTerm value is 3 and the loanAmount value is 9750, the loanRate must be set
//to 8.25 percent. You need to adjust the loanRate value to meet the requirements.
//What should you do?

//A.
//Replace line 04 with the following code segment: 
//decimal loanRate = 0.0325m;

//B.
//Replace line 17 with the following code segment: 
//interestAmount = loanAmount * 0.0825m * loanTerm;

//C.
//Replace line 15 with the following code segment: 
//loanRate = 0.0825m;

//D.
//Replace line 07 with the following code segment: 
//loanRate = 0.0825m;


//RESPOSTA: C

