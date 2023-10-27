using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace EmployeeOOP.Classes
{
    [Serializable]
    internal class YearException : Exception
    {
        public YearException()
        {
        }

        public YearException(string? message) : base(message)
        {
        }

        public YearException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected YearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
