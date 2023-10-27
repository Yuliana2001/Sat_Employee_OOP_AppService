using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    [Serializable]
    internal class DayException : Exception
    {
        public DayException()
        {
        }

        public DayException(string? message) : base(message)
        {
        }

        public DayException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
