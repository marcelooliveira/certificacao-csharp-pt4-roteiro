namespace Q13
{
    class Programa
    {
        public void Executar()
        {

        }

        private string GetMemberType(int memberCode)
        {
            string memberType;
            switch (memberCode)
            {
                case 0:
                    memberType = "Non-Member";
                    break;
                case 1:
                    memberType = "Member";
                    break;
                default:
                    memberType = "Invalid";
                    break;
            }
            return memberType;
        }
    }
}

//How should you complete the relevant code?

//DRAG DROP

//You are adding a function to a membership tracking application- The function uses an
//integer named memberCode as an input parameter and returns the membership type as a
//string.
//The function must meet the following requirements:
//Return “Non-Member” if the memberCode is 0.
//Return “Member” if the memberCode is 1.
//Return “Invalid” if the memberCode is any value other than 0 or 1.
//You need to implement the function to meet the requirements.
//How should you complete the relevant code? (To answer, drag the appropriate statements
//to the correct locations in the answer area. Each statement may be used once, more than
//once, or not at all. You may need to drag the split bar between panes or scroll to view content.)

//```
//default
//switch
//break
//case
//```

//```
//private string GetMemberType(int memberCode)
//{
//    string memberType;
//    [LACUNA 1] (memberCode)
//    {
//        [LACUNA 2] 0:
//            memberType = "Non-Member";
//            [LACUNA 3];
//        [LACUNA 4] 1:
//            memberType = "Member":
//            [LACUNA 5];
//        [LACUNA 6]:
//            memberType = "Invalid":
//        [LACUNA 7];
//    }
//    return memberType;
//}

//```

//# resposta

//```
//[LACUNA 1] switch
//[LACUNA 2] case
//[LACUNA 3] break
//[LACUNA 4] case
//[LACUNA 5] break
//[LACUNA 6] default
//[LACUNA 7] break
//```
