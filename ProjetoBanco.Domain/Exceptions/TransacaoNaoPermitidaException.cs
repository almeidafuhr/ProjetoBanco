using System;

namespace ProjetoBanco.Domain.Exceptions
{
    public class TransacaoNaoPermitidaException : Exception
    {
        public TransacaoNaoPermitidaException(string message) : base(message) { }
    }
}
