using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Q15
{
    class Programa
    {
        public void Executar()
        {
            IList<Cliente> clientes = new List<Cliente>();
            IList<Conta> contas = new List<Conta>
            {
                new Conta(1000m, 2, 0.025m),
                new Conta(3000m, 4, 0.045m),
                new Conta(5000m, 6, 0.045m)
            };

            clientes.Add(new Cliente("José", "Silva", contas));

            Collection<Conta> contasEspeciais = new Collection<Conta>();

            foreach (Cliente cliente in clientes)
            {
                foreach (Conta conta in cliente.Contas)
                {
                    if (conta.Saldo >= 1000000m)
                    {
                        contasEspeciais.Add(conta);
                    }
                }
            }
        }
    }

    class Conta
    {
        public Conta(decimal saldo, int periodo, decimal juros)
        {
            Periodo = periodo;
            Saldo = saldo;
            Juros = juros;
        }
        public decimal Saldo { get; set; }
        public decimal Juros { get; set; }
        public int Periodo { get; set; }
    }

    class Cliente
    {
        public Cliente(string nome, string sobrenome, IList<Conta> contas)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Contas = contas;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public IList<Conta> Contas { get; set; }
    }
}

//Qual segmento de código você deve usar?

//Você está modificando um aplicativo bancário existente. O aplicativo inclui uma classe `Account` e uma classe `Customer`.
//O seguinte código segmento define as classes.


//```
//class Programa
//{
//    public void Executar()
//    {
//        IList<Cliente> clientes = new List<Cliente>();
//        IList<Conta> contas = new List<Conta>
//            {
//                new Conta(1000m, 2, 0.025m),
//                new Conta(3000m, 4, 0.045m),
//                new Conta(5000m, 6, 0.045m)
//            };

//        clientes.Add(new Cliente("José", "Silva", contas));

//        Collection<Conta> contasEspeciais = new Collection<Conta>();

//        foreach (Cliente cliente in clientes)
//        {
//            foreach (Conta conta in cliente.Contas)
//            {
//                if (conta.Saldo >= 1000000m)
//                {
//                    contasEspeciais.Add(conta);
//                }
//            }
//        }
//    }
//}

//class Conta
//{
//    public Conta(decimal saldo, int periodo, decimal juros)
//    {
//        Periodo = periodo;
//        Saldo = saldo;
//        Juros = juros;
//    }
//    public decimal Saldo { get; set; }
//    public decimal Juros { get; set; }
//    public int Periodo { get; set; }
//}

//class Cliente
//{
//    public Cliente(string nome, string sobrenome, IList<Conta> contas)
//    {
//        Nome = nome;
//        Sobrenome = sobrenome;
//        Contas = contas;
//    }
//    public string Nome { get; set; }
//    public string Sobrenome { get; set; }
//    public IList<Conta> Contas { get; set; }
//}
//```

//Você preenche uma coleção chamada `clientes` com objetos `Cliente` e `Conta` 
//usando o seguinte segmento de código:

//```
//IList<Cliente> clientes = new List<Cliente>();
//IList<Conta> contas = new List<Conta>();
//contas.Add(new Account(1000m, 2, 0.025m));
//contas.Add(new Account(3000m, 4, 0.045m));
//contas.Add(new Account(5000m, 6, 0.045m)):
//clientes.Add(new Cliente("José", "Silva", contas));
//```

//Você cria uma coleção `contasEspeciais` para armazenar os objetos `Conta` usando o segmento de código a seguir:

//```
//Collection<Conta> contasEspeciais = new Collection<Conta>();
//```
//Todas as contas com um valor de saldo maior ou igual a 1.000.000 devem ser rastreadas.
//Você precisa preencher a coleção `contasEspeciais` com objetos `Conta`.

//Qual segmento de código você deve usar?

//```
//A
//foreach (Cliente cliente in clientes)
//{
//    foreach (Conta conta in cliente.Contas)
//    {
//        if (conta.Saldo >= 1000000m)
//        {
//            cliente.Contas.Add(conta);
//        }
//    }
//}

//B
//foreach (Cliente cliente in clientes)
//{
//    foreach (Conta conta in contasEspeciais)
//    {
//        if (conta.Saldo >= 1000000m)
//        {
//            contasEspeciais.Add(conta);
//        }
//    }
//}

//C
//foreach (Cliente cliente in clientes)
//{
//    foreach (Conta conta in cliente.Contas)
//    {
//        if (conta.Saldo >= 1000000m)
//        {
//            contasEspeciais.Add(conta);
//        }
//    }
//}

//D
//foreach (Conta conta in contasEspeciais)
//{
//    foreach (Cliente cliente in clientes)
//    {
//        if (conta.Saldo >= 1000000m)
//        {
//            cliente.Contas.Add(conta);
//        }
//    }
//}
//```


