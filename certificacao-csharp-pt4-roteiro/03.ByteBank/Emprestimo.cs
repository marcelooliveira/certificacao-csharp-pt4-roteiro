using System;
using System.Diagnostics;
using System.IO;

namespace _03.ByteBank
{
    public class Emprestimo
    {
        private int prazo;
        private const int PRAZO_MAXIMO_PAGAMENTO_ANOS = 5;
        private const decimal JUROS = 0.034m;
        private readonly string CodigoContrato;
        private static readonly string arquivoLog = GetArquivo();

        public Emprestimo(string codigoContrato)
        {
            bool codigoContratoValido = ValidarCodigo(codigoContrato);

            if (!codigoContratoValido)
            {
                throw new ArgumentException("código de contrato inválido");
            }

            CodigoContrato = codigoContrato;
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
#if DEBUG
            ImprimirTesteNoConsole(valorComJuros);
#endif  
            Log($"Valor com juros: {valorComJuros:c2}");

            if (Debugger.IsAttached)
            {
                Process.Start("notepad.exe", arquivoLog);
            }

            return valorComJuros;
        }

        [Conditional("DEBUG")]
        private static void ImprimirTesteNoConsole(decimal valorComJuros)
        {
            Console.WriteLine($"Valor com juros: {valorComJuros:c2}");
        }

        private static void Log(string texto)
        {
            using (var writer = new StreamWriter(arquivoLog, append: true))
            {
                writer.WriteLine(texto);
            }
        }

        private static string GetArquivo()
        {
            string caminhoImg = "";
#if (DEBUG)
            caminhoImg = "Debug/Images/";
#else
            caminhoImg = "Release/Images/":
#endif
            Directory.CreateDirectory(caminhoImg);

            return Path.Combine(caminhoImg, "log.txt");
        }

        public void Finalizar()
        {
#if TRIAL
                AvaliarEmprestimo();
#elif BASIC
                AvaliarEmprestimo();
                ProcessarEmprestimo();
                FinanciarEmprestimo();
#else
            AvaliarEmprestimo();
            ProcessarEmprestimo();
#endif
        }

        private void FinanciarEmprestimo()
        {
            Console.WriteLine("FinanciarEmprestimo");
        }

        private void ProcessarEmprestimo()
        {
            Console.WriteLine("ProcessarEmprestimo");
        }

        private void AvaliarEmprestimo()
        {
            Console.WriteLine("AvaliarEmprestimo");
        }
    }

    public delegate void PrazoMaximoEstouradoHandler(object source, EventArgs e);
}
