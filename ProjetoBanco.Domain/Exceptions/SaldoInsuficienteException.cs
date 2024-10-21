using System;

namespace ProjetoBanco.Domain.Exceptions
{
    class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string message) : base("Saldo insuficiente para realizar esta operação.") { }

        public SaldoInsuficienteException(decimal saldo, decimal valorTentativa)
        : base($"Tentativa de saque de {valorTentativa:C} com saldo disponível de {saldo:C}.") { }
    }


}
