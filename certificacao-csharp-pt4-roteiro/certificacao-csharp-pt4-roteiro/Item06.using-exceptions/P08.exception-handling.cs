using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt4_roteiro
{
    class P08
    {
        static void Executar()
        {
            try
            {
                // Try to access a resource.
            }
            catch (System.UnauthorizedAccessException e)
            {
                // Call a custom error logging procedure.
                LogError(e);
                // Re-throw the error.
                throw;
            }

            System.IO.FileStream file = null;
            System.IO.FileInfo fileinfo = new System.IO.FileInfo("C:\\file.txt");
            try
            {
                file = fileinfo.OpenWrite();
                file.WriteByte(0xF);
            }
            finally
            {
                // Check for null because OpenWrite might have failed.
                if (file != null)
                {
                    file.Close();
                }
            }
        }

        private static void LogError(UnauthorizedAccessException e)
        {
            throw new NotImplementedException();
        }

        int GetInt(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (System.IndexOutOfRangeException e)
            {
                throw new System.ArgumentOutOfRangeException(
                    "Parameter index is out of range.", e);
            }
        }
    }
}
