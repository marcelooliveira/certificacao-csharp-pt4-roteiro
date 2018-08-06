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
                if (value > PRAZO_MAXIMO_PAGAMENTO_ANOS)
                {
                    if (OnPrazoMaximoEstourado == null)
                    {
                        Console.WriteLine("OnPrazoMaximoEstourado não informado!");
                        return;
                    }
                    OnPrazoMaximoEstourado(this, new EventArgs());
                    return;
                }
                prazo = value;
            }
        }

        public static decimal CalcularJuros(decimal valor, int prazo)
        {
            decimal valorJuros;
            decimal taxaJuros;
            if (prazo > 0 && prazo < 5 && valor < 7000m) //falso
            {
                taxaJuros = 0.035m;
            }
            else if (prazo > 5 && valor > 7000m) //falso
            {
                taxaJuros = 0.075m;
            }
            else
            {
                //taxaJuros = 0.045m;
                taxaJuros = 0.0875m;
            }
            valorJuros = valor * taxaJuros * prazo;
            return valorJuros;
        }
    }
}
