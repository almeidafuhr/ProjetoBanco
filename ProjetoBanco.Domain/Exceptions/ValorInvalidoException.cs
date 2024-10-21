using System;

namespace ProjetoBanco.Domain
{
    public class ValorInvalidoException : ArgumentException
    {
        public ValorInvalidoException(string message, string paramName) : base(message, paramName) { }
    }
}
