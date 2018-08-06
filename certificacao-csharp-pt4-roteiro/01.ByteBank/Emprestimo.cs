using System;

namespace _01.ByteBank
{
    public class Emprestimo
    {
        private int prazo;
        private const int PRAZO_MAXIMO_PAGAMENTO_ANOS = 5;
        private const decimal JUROS = 0.034m;

        private string codigoContrato;

        public void RedefinirCodigoContrato(string codigoContrato)
        {
            if (!ValidarCodigo(codigoContrato))
            {
                Console.WriteLine("código de contrato inválido");
                return;
            }
            this.codigoContrato = codigoContrato;
        }

        private bool ValidarCodigo(string codigoContrato)
        {
            bool codigoContratoValido = true;
            foreach (var caractere in codigoContrato)
            {
                if (!(Char.IsDigit(caractere) || Char.IsUpper(caractere)))
                {
                    codigoContratoValido = false;
                    break;
                }
            }

            return codigoContratoValido;
        }

        public Emprestimo(string codigoContrato)
        {
            this.codigoContrato = codigoContrato;
        }


        public event PrazoMaximoEstouradoHandler OnPrazoMaximoEstourado;

        public int Prazo
        {
            get
            {
                return prazo;
            }
            set
            {
                if (value <= PRAZO_MAXIMO_PAGAMENTO_ANOS)
                {
                    prazo = value;
                }
                else
                {
                    //if (null)
                    //{
                    //    Console.WriteLine("OnPrazoMaximoEstourado não informado!");
                    //}

                    //if (OnPrazoMaximoEstourado == null)
                    //{
                    //    Console.WriteLine("OnPrazoMaximoEstourado não informado!");
                    //    return;
                    //}
                    
                    if (OnPrazoMaximoEstourado != null)
                    {
                        OnPrazoMaximoEstourado(this, new EventArgs());
                    }
                }
            }
        }

        public static decimal CalcularValorComJuros(decimal valorEmprestimo, int prazoEmprestimo)
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
