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

//Which code segment should you use?

//You are modifying an existing banking application.
//The application includes an Account class and a Customer class. The following code
//segment defines the classes.


//```
//class Account
//{
//    public Account(decimal balance, int term, decimal rate)
//    {
//        Term = term;
//        Balance = balance;
//        Rate = rate;
//    }
//    public decimal Balance { get; set; }
//    public decimal Rate { get; set; }
//    public int Term { get; set; }
//}

//class Customer
//{
//    public Customer(string firstName, string lastName, Collection accounts)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//        AccountCollection = accounts;
//    }
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public Collection<Account> AccountCollection { get; set; }
//}
//```

//You populate a collection named customerCollection with Customer and Account objects by
//using the following code segment:

//```
//Collection<Collection> customerCollection = new Collection();
//Collection<Account> customerAccounts = new Collection();
//customerAccounts.Add(new Account(1000m, 2, 0.025m));
//customerAccounts.Add(new Account(3000m, 4, 0.045m));
//customerAccounts.Add(new Account(5000m, 6, 0.045m)):
//customerCollection.Add(new Customer("David", "Jones", customerAccounts));
//```

//You create a largeCustomerAccounts collection to store the Account objects by using the
//following code segment:
//Collection<Account> largeCustomerAccounts = new Collection<Account> ();
//All accounts with a Balance value greater than or equal to 1,000,000 must be tracked.
//You need to populate the largeCustomerAccounts collection with Account objects.
//Which code segment should you use?

//```
//A
//foreach (Customer customer in customerCollection)
//{
//    foreach (Account account in customer.AccountCollection)
//    {
//        if (account.Balance >= l000000m)
//        {
//            customer.AccountCollection.Add(account);
//        }
//    }
//}

//B
//foreach (Account customer in customerCollection)
//{
//    foreach (Account account in largeCustomerAccounts)
//    {
//        if (account.Balance >= l000000m)
//        {
//            largeCustomerAccounts.Add(account);
//        }
//    }
//}

//C
//foreach (Customer customer in customerCollection)
//{
//    foreach (Account account in customer.AccountCollection)
//    {
//        if (account.Balance >= l000000m)
//        {
//            largeCustomerAccounts.Add(account);
//        }
//    }
//}

//D
//foreach (Account account in largeCustomerAccounts)
//{
//    foreach (Customer customer in customerCollection)
//    {
//        if (account.Balance >= l000000m)
//        {
//            customer.AccountCollection.Add(account);
//        }
//    }
//}
//```

//RESPOSTA C.
//Option C

