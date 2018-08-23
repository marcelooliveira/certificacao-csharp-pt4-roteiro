//Como você deveria completar o código relevante?

//Você está desenvolvendo um aplicativo que exibe informações de arquivos de log quando ocorrem erros.
//O aplicativo solicitará que o usuário crie um relatório de erros que envie detalhes sobre o erro e a sessão para o administrador.

//Quando um usuário abre um arquivo de log usando o aplicativo, o aplicativo lança uma exceção e fecha.
//O aplicativo deve preservar as informações de rastreamento de pilha original quando ocorre uma exceção durante este processo.
//Você precisa implementar o método que lê os arquivos de log.

//Como você deve completar o código relevante nas lacunas abaixo?


//```
//opções:
//=======
//using (StringReader sr = new StringReader("log.txt"))
//using (StreamReader sr = new StreamReader("log.txt"))
//throw new FileNotFoundException:
//throw;

//código:
//=======

//[LACUNA 1]
//{
//    try
//    {
//        string line;
//        while ((line = sr.ReadLine()) != null)
//        {
//            Console.WriteLine(line);
//        )
//    }
//    catch (FileNotFoundException e)
//    {
//        Console.Write(e.ToString());
//        [LACUNA 2]
//    )
//)
//```



