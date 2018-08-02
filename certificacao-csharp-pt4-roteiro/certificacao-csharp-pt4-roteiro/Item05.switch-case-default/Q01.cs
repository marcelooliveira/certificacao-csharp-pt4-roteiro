class Q01
{
    //How should you complete the relevant code?

    //HOTSPOT
    //You are implementing a library method that accepts a character parameter and returns a
    //string.
    //If the lookup succeeds, the method must return the corresponding string value. If the lookup
    //fails, the method must return the value “invalid choice.”
    //You need to implement the lookup algorithm.
    //How should you complete the relevant code? (To answer, select the correct keyword in each
    //drop-down list in the answer area.)

    //```
    //public string GetResponse(char letter)
    //{
    //    string response;
    //    [LACUNA 1](letter)
    //    {
    //        [LACUNA 2] 'a':
    //            response = "animal":
    //            break;
    //        [LACUNA 3] 'm':
    //            response = "mineral";
    //            break:
    //        [LACUNA 4]:
    //            response = "invalid choice";
    //            break:
    //    }
    //    return response;
    //}
    //```

    //# RESPOSTA:

    //```
    public string GetResposta(char letra)
    {
        string resposta;
        switch (letra)
        {
            case 'a':
                resposta = "animal";
                break;
            case 'm':
                resposta = "mineral";
                break;
            default:
                resposta = "escolha inválida";
                break;
        }
        return resposta;
    }
    //```
}
