using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt4_roteiro
{
    class P09
    {
        static void Executar()
        {
        }

        static void CopyObject(SampleClass original)
        {
            if (original == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "original");
            }

        }

        static int GetValueFromArray(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (System.IndexOutOfRangeException ex)
            {
                System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex);
                throw argEx;
            }
        }
    }

    internal class SampleClass
    {
    }

    class ProgramLog
    {
        System.IO.FileStream logFile = null;
        void OpenLog(System.IO.FileInfo fileName, System.IO.FileMode mode) { }

        void WriteLog()
        {
            if (!this.logFile.CanWrite)
            {
                throw new System.InvalidOperationException("Logfile cannot be read-only");
            }
            // Else write data to the log and return.
        }
    }

    [Serializable()]
    public class InvalidDepartmentException : System.Exception
    {
        public InvalidDepartmentException() : base() { }
        public InvalidDepartmentException(string message) : base(message) { }
        public InvalidDepartmentException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidDepartmentException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
