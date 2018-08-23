//Você está criando um método que salva informações em um banco de dados.

//Você tem uma classe estática chamada `LogHelper`, que tem um método chamado `Log` para registrar exceção.

//Você precisa usar o método `Log` do `LogHelper` para registrar a exceção gerada pelo servidor de banco de dados. 

//A solução deve garantir que a exceção possa ser capturada pelo método de chamada, enquanto preserva o rastreio de pilha original.

//Como você deve escrever o bloco `catch`?

//```
//catch {
//catch (SqlException ex) {
//catch (FileNotFoundException ex) {
//throw;
//}
//throw new FileNotFoundException();
//throw ex;
//LogHelper.Log(ex);
//throw new SqlException();
//```


//A
//catch (SqlException ex) {
//LogHelper.Log(ex)
//throw;
//}


//B
//catch (SqlException ex) {
//throw;
//LogHelper.Log(ex)
//}


//C
//catch (SqlException ex) {
//LogHelper.Log(ex)
//throw new SqlException();
//}


//D
//catch (FileNotFoundException ex) {
//throw;
//}
//catch (SqlException ex) {
//LogHelper.Log(ex)
//throw new SqlException();
//}
