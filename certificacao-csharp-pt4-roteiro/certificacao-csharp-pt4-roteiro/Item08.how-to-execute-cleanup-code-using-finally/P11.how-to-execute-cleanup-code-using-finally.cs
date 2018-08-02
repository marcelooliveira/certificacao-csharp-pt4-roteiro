using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt4_roteiro
{
    class P11
    {
        static void Executar()
        {
        }

        static void CodigoSemLimpeza()
        {
            System.IO.FileStream file = null;
            System.IO.FileInfo fileInfo = new System.IO.FileInfo("C:\\file.txt");

            file = fileInfo.OpenWrite();
            file.WriteByte(0xF);

            file.Close();
        }

        static void CodigoComLimpeza()
        {
            System.IO.FileStream file = null;
            System.IO.FileInfo fileInfo = null;

            try
            {
                fileInfo = new System.IO.FileInfo("C:\\file.txt");

                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            catch (System.UnauthorizedAccessException e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }
    }
}
