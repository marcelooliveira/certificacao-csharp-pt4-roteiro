using System;

namespace certificacao_csharp_pt4_roteiro
{
    class P05
    {
        static void Executar()
        {
            IfSemElse(); /*OK*/
            IfElse(); /*OK*/
            IfAninhado(); /*OK*/
            IfTesteCaracteres();/*OK*/
            IfTesteConsoleRead(); /*OK*/
            IfNot(); /*OK*/
            IfAndOr(); /*OK*/
        }

        private static void SacarDinheiro(decimal quantia)
        {
            if (TemSaldoSuficiente(quantia))
            {
                Sacar(quantia);
                ImprimirComprovante();
            }
            else
            {
                Console.WriteLine("Saldo indisponível");
            }
        }

        private static bool TemSaldoSuficiente(decimal quantia)
        {
            return true;
        }

        private static void ImprimirComprovante()
        {
            Console.WriteLine("ImprimirComprovante");
        }

        private static void Sacar(decimal quantia)
        {
            Console.WriteLine("Sacar");
        }

        private static void IfSemElse()
        {
            // instrução if sem um else  
            bool condicao = true;
            if (condicao)
            {
                //instrução then;
                FacaAlgo();
            }
            // Próxima instrução do programa. 
        }

        private static void FacaAlgo()
        {
            //throw new NotImplementedException();
        }

        private static bool IfElse()
        {
            bool condicao = true;

            if (condicao)
            {
                Console.WriteLine(
                    "A expressão foi avaliada como verdadeiro.");
            }
            else
            {
                Console.WriteLine(
                    "A expressão foi avaliada como falso.");
            }

            return condicao;
        }

        private static void IfAninhado()
        {
            // Tenta com m = 12 e depois com m = 8
            int m = 12;
            int n = 18;

            if (m > 10)
                if (n > 20)
                {
                    Console.WriteLine("Resultado 1");
                }
                else
                {
                    Console.WriteLine("Resultado 2");
                }




            // Tenta com m = 12 e depois com m = 8
            if (m > 10)
            {
                if (n > 20)
                    Console.WriteLine("Result1");
            }
            else
            {
                Console.WriteLine("Result2");
            }
        }

        private static void IfTesteCaracteres()
        {
            Console.Write("Digite um caractere: ");
            char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("O caractere é minúsculo.");
                }
                else
                {
                    Console.WriteLine("O caractere é maiúsculo.");
                }
            }
            else
            {
                Console.WriteLine("O caractere não é alfabético.");
            }
        }

        //private static void IfThenElseIfElse()
        //{
        //    string texto = "else if";

        //    if (texto == "if")
        //    {
        //        Console.WriteLine("bloco then");
        //    }
        //    else if (texto == "else if")
        //    {
        //        Console.WriteLine("else if");
        //    }
        //    else if (texto == "else if 2")
        //    {
        //        Console.WriteLine("else if 2");
        //    }
        //    else
        //    {
        //        Console.WriteLine("else");
        //    }
        //}

        private static void IfThenElseIfElse()
        {
            bool valor = true;

            if (valor)
            {
                Console.WriteLine("bloco then");
            }
            else if (valor)
            {
                Console.WriteLine("else if");
            }
            else if (valor)
            {
                Console.WriteLine("else if 2");
            }
            else
            {
                Console.WriteLine("else");
            }
        }

        private static void IfTesteConsoleRead()
        {
            Console.Write("Digite um caractere: ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("O caractere é maiúsculo.");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("O caractere é minúsculo.");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("O caractere é um número.");
            }
            else
            {
                Console.WriteLine("O caractere não é alfanumérico.");
            }
        }

        private static void IfNot()
        {
            // NOT  
            bool resultado = true;
            if (!resultado)
            {
                Console.WriteLine("A condição é verdadeira (resultado é falso).");
            }
            else
            {
                Console.WriteLine("A condição é falsa (resultado é verdadeiro).");
            }
        }

        private static void IfAndOr()
        {
            // AND curto-circuito
            int m1 = 9;
            int n1 = 7;
            int p1 = 5;
            if (m1 >= n1 && m1 >= p1)
            {
                Console.WriteLine("Nada é maior que m.");
            }

            // AND e NOT
            if (m1 >= n1 && !(p1 > m1))
            {
                Console.WriteLine("Nada é maior que m.");
            }

            // OR curto-circuito
            if (m1 > n1 || m1 > p1)
            {
                Console.WriteLine("m não é o menor.");
            }

            // NOT e OR  
            m1 = 4;
            if (!(m1 >= n1 || m1 >= p1))
            {
                Console.WriteLine("agora me é o menor.");
            }
        }
    }

    public class Emprestimo
    {

        private int prazo;
        private const int PRAZO_MAXIMO_PAGAMENTO_ANOS = 5;
        private const decimal JUROS = 0.034m;

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
                    //if (OnPrazoMaximoEstourado != null)
                    //{
                    //    OnPrazoMaximoEstourado(this, new EventArgs());
                    //}
                }
            }
        }
    }

    public delegate void PrazoMaximoEstouradoHandler(object source, EventArgs e);
}
