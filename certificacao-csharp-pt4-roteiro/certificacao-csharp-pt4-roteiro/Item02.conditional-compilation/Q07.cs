namespace Q07
{
    class Programa
    {
        public void Executar()
        {
            string caminhoImg = "";
            #if (DEBUG)
                caminhoImg = "DiretorioLocal/Imagens/";
            #else
                caminhoImg = "DiretorioRede/Imagens/";
            #endif
        }
    }
}

//Qual segmento de código você deve usar?

//Você está desenvolvendo um aplicativo para processamento de pedidos.
//The debug and release versions
//As versões de _debug_ e _release_
//do aplicativo exibirão imagens de logotipo diferentes.
//Você precisa garantir que o caminho correto da imagem seja definido com base na configuração da compilação.

//Qual segmento de código você deve usar?


//```
//#if (DEBUG)
//    imgPath = "DiretorioLocal/Imagens/";
//#elif (RELEASE)
//    imgPath = "DiretorioRede/Imagens/":
//#endif

//if (DEBUG)
//    imgPath = "DiretorioLocal/Imagens/";
//else
//    imgPath = "DiretorioRede/Imagens/";
//endif

//#if (DEBUG)
//    imgPath = "DiretorioLocal/Imagens/";
//#else
//    imgPath = "DiretorioRede/Imagens/":
//#endif

//if (Debugger.IsAttached)
//{
//    imgPath = "DiretorioLocal/Imagens/":
//}
//else
//{
//    imgPath = "DiretorioRede/Imagens/";
//}
//```

