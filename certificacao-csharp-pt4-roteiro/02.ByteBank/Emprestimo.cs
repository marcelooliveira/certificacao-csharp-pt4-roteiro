using System;
using System.Diagnostics;
using System.IO;

namespace _02.ByteBank
{
    public class Emprestimo
    {
        private int prazo;
        private const int PRAZO_MAXIMO_PAGAMENTO_ANOS = 5;
        private const decimal JUROS = 0.034m;
        private string codigoContrato;
        private static readonly string arquivoLog = GetArquivoLog();

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
                taxaJuros = 0.0875m;
            }

            valorJuros = valor * taxaJuros * prazo;
#if DEBUG
            ImprimirTesteNoConsole(valorJuros);
#endif  
            Log($"Valor com juros: {valorJuros:c2}");

            if (Debugger.IsAttached)
            {
                Process.Start("notepad.exe", arquivoLog);
            }

            return valorJuros;
        }

        [Conditional("TESTE")]
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

        private static string GetArquivoLog()
        {
            string caminhoLog;
#if (DEBUG)
            //CAMINHO NA MÁQUINA DO DESENVOLVEDOR
            caminhoLog = "Debug/Logs/"; 
#else
            //CAMINHO NO SERVIDOR DE PRODUÇÃO
            caminhoImg = @"\\192.1.1.55\Logs\"; 
#endif
            Directory.CreateDirectory(caminhoLog);

            return Path.Combine(caminhoLog, "log.txt");
        }

        public void Finalizar()
        {
            //REGRAS:
            //=======
            //No modo TRIAL, somente o método AvaliarEmprestimo() deve ser chamado.
            //No modo BASIC, os três métodos devem ser chamados.
            //NO modo ADVANCED, somente os métodos AvaliarEmprestimo() e
            //      ProcessarEmprestimo() devem ser chamados.

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
}
