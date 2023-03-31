using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Exceptions
{
    public class EmptyFileNameException : Exception
    {
        private const string DefaultMessage =
        "File name cannot be null or whitespace";

        public EmptyFileNameException()
            : base(DefaultMessage)
        {
        }

        public EmptyFileNameException(string message)
            : base(message)
        {
        }
    }
}
