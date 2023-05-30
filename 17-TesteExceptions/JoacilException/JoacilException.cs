using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_TesteExceptions.JoacilExpection
{
    public class JoacilException : Exception
    {
        public JoacilException() { }
        public JoacilException(string message) : base("Aconteceu uma Excessão: " + message) { }
        public JoacilException(string message, Exception inner) : base("Aconteceu uma Excessão: " + inner) { }

        protected JoacilException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

    }
}
