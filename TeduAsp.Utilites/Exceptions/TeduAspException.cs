using System;
using System.Collections.Generic;
using System.Text;

namespace TeduAsp.Utilites.Exceptions
{
    public class TeduAspException : Exception
    {
        public TeduAspException()
        {
        }

        public TeduAspException(string message) : base(message)
        {
        }

        public TeduAspException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
