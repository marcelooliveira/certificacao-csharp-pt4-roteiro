﻿namespace Q07
{
    class Programa
    {
        public void Executar()
        {
            string caminhoImg = "";
            #if (DEBUG)
                caminhoImg = "TempFolder/Images/";
            #else
                imgPath = "DevFolder/Images/":
            #endif
        }
    }
}
//Which code segment should you use?

//You are developing an application that will process orders. The debug and release versions
//of the application will display different logo images.
//You need to ensure that the correct image path is set based on the build configuration.
//Which code segment should you use?

//```
//#if (DEBUG)
//    imgPath = "TempFolder/Images/";
//#elif (RELEASE)
//    imgPath = "DevFolder/Images/":
//#endif

//if (DEBUG)
//    imgPath = "TempFolder/Images/";
//else
//    imgPath = "DevFolder/Images/";
//endif

//#if (DEBUG)
//    imgPath = "TempFolder/Images/";
//#else
//    imgPath = "DevFolder/Images/":
//#endif

//if (Debugger.IsAttached)
//{
//    imgPath = "TempFolder/Images/":
//}
//else
//{
//    imgPath = "DevFolder/Images/";
//}
//```

//RESPOSTA

//C.
//Option C
