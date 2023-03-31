using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Exceptions
{
    public class EmptyMessageException : Exception
    {
        private const string DefaultMessage = "Message text cannot be null or whitespace";
        public EmptyMessageException() : base(DefaultMessage) 
        {
            
        }
        public EmptyMessageException(string message) : base(message)
        {

        }
    }
}
