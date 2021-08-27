using System;

namespace IfeedsApi.Domain.Exceptions
{
    public class EntidadeEmUsoException : Exception
    {
        public EntidadeEmUsoException(string message) : base(message)
        {

        }
    }
}