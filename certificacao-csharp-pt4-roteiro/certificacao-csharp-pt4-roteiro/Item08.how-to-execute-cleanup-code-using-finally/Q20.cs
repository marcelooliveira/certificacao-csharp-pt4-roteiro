//Você tem um aplicativo que acessa um banco de dados do Microsoft SQL Server.

//O banco de dados contém um procedimento armazenado chamado `proc1`, que acessa várias linhas de dados em várias tabelas.

//Você precisa garantir que, após a execução de `proc1`, o banco de dados fique em um estado consistente.

//Você tem um aplicativo que acessa um banco de dados do Microsoft SQL Server.

//O banco de dados contém um procedimento armazenado chamado `proc1`, que acessa várias linhas de dados em várias tabelas.

//Você precisa garantir que, após a execução de `proc1`, o banco de dados fique em um estado consistente.

//Para atender esses requisitos, monte um algoritmo na sequência correta, escolhendo entre os blocos de código abaixo:


//```
//[Bloco 1]
//try
//{
//    connection.Open();
//    command.ExecuteNonQuery();
//```

//```
//[Bloco 2]
//SqlConnection connection = new SqlConnection(connectionString);
//SqlCommand command = new SqlCommand("proc1", connection);
//```

//```
//[Bloco 3]
//SqlTransaction transaction = connection.BeginTransaction();
//```

//```
//[Bloco 4]
//}
//finally
//{
//```

//```
//[Bloco 5]
//transaction.Rollback();
//```

//```
//[Bloco 6]
//transaction.Commit();
//```

//```
//[Bloco 7]
//command.Dispose();
//    connection.Dispose();
//}
//```

//```
//[Bloco 8]
//}
//catch
//{
//```