namespace Q23
{
    class Programa
    {
        public void Executar()
        {

        }

        string GetStatusName(int statusCode)
        {
            string statusText = "";
            switch (statusCode)
            {
                case 0:
                    statusText = "Error";
                    break;
                case 1:
                    statusText = "Success";
                    break;
                default:
                    statusText = "Unauthorized";
                    break;
            }
            return statusText;
        }
    }
}

//How should you complete the relevant code?

//DRAG DROP
//You are adding a method to an existing application. The method uses an integer named
//statusCode as an input parameter and returns the status code as a string.
//The method must meet the following requirements:
//Return “Error” if the statusCode is 0.
//Return “Success” if the statusCode is 1.
//Return “Unauthorized” if the statusCode is any value other than 0 or l.
//You need to implement the method to meet the requirements.
//How should you complete the relevant code? (To answer, drag the appropriate statements
//to the correct locations in the answer area. Each statement may be used once, more than
//once, or not at all. You may need to drag the split bar between panes or scroll to view content.)

//**OPÇÕES**

//```
//default
//switch
//break
//case
//```

//```
//string statusText;
//[LACUNA 1](statusCode)
//{
//    [LACUNA 2] 0:
//        statusText = "Error";
//        [LACUNA 3];
//    [LACUNA 4] 1:
//        statusText = "Success";
//        [LACUNA 5];
//    [LACUNA 6]:
//        statusText = "Unauthorized”;
//        [LACUNA 7]:
//}
//return statusText;
//```


//```
//[LACUNA 1] switch
//[LACUNA 2] case
//[LACUNA 3] break
//[LACUNA 4] case
//[LACUNA 5] break
//[LACUNA 6] default
//[LACUNA 7] break
//```

