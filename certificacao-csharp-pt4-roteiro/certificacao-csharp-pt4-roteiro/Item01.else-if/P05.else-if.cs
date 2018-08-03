using System;

namespace certificacao_csharp_pt4_roteiro
{
    class P05
    {
        static void Executar()
        {
            IfElse(); /*OK*/
            IfSemElse(); /*OK*/
            IfAninhado(); /*OK*/
            IfTesteCaracteres();/*OK*/
            IfTesteConsoleRead(); /*OK*/
            IfNot(); /*OK*/
            IfAndOr(); /*OK*/
        }

        private static void IfSemElse()
        {
            // instrução if sem um else  
            bool condicao = true;
            if (condicao)
            {
                //instrução then;
            }
            // Próxima instrução do programa. 
        }

        private static bool IfElse()
        {
            bool condicao = true;

            if (condicao)
            {
                Console.WriteLine("A variável foi definida como verdadeiro.");
            }
            else
            {
                Console.WriteLine("A variável foi definida como falso.");
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

        //public event PrazoMaximoEstouradoHandler OnPrazoMaximoEstourado;

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
