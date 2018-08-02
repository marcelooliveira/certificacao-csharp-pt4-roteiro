using System;
using System.Data.SqlClient;

namespace Q14
{
    class Programa
    {
        public void Executar()
        {
            try
            {

            }
            catch (SqlException ex)
            {
                LogHelper.Log(ex);
                throw;
            }
        }
    }

    internal class LogHelper
    {
        internal static void Log(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}

//How should you write the catch block?

//DRAG DROP
//You are creating a method that saves information to a database.
//You have a static class named LogHelper. LogHelper has a method named Log to log the
//exception.
//You need to use the LogHelper Log method to log the exception raised by the database
//server. The solution must ensure that the exception can be caught by the calling method,
//while preserving the original stack trace.
//How should you write the catch block? (Develop the solution by selecting and ordering the
//required code snippets. You may not need all of the code snippets.)

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

//![](https://cdn.briefmenow.org/wp-content/uploads/70-483-v2/167.jpg)

//Explanation:
//Box 1:

//catch (SqlException ex) {

//Box 2:

//LogHelper.Log(ex)

//Box 3:

//throw;

//Box 4:

//}

//Note:
//Catch the database exception, log it, and then rethrow it.

//* SQLException
//An exception that provides information on a database access error or other errors.

