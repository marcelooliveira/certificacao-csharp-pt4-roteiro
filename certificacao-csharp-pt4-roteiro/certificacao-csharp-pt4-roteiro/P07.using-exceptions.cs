using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt4_roteiro
{
    class P07
    {
        static void Executar()
        {
            System.IO.FileStream file = null;
            //Change the path to something that works on your machine.
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(@"C:\file.txt");

            try
            {
                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            finally
            {
                // Closing the file allows you to reopen it immediately - otherwise IOException is thrown.
                if (file != null)
                {
                    file.Close();
                }
            }

            try
            {
                file = fileInfo.OpenWrite();
                System.Console.WriteLine("OpenWrite() succeeded");
            }
            catch (System.IO.IOException)
            {
                System.Console.WriteLine("OpenWrite() failed");
            }
        }
    }
}
