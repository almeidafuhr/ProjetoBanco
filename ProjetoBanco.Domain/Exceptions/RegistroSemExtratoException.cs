using System;

namespace ProjetoBanco.Domain.Exceptions
{
    public class RegistroSemExtratoException : Exception
    {
        public RegistroSemExtratoException(string message) : base(message) { }


    }
}
