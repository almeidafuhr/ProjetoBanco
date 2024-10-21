using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain
{
    class ExtratoTransacoes
    {
        List<Transacao> Registros { get; set; }

        public decimal CalcularSaldoEntradas()
        {
            decimal soma = 0M;
            foreach (var registros in Registros)
            {
                soma += soma + registros.Valor;
            }
            return soma;
        }

        public decimal CalcularSaldoSaidas()
        {
            decimal soma = 0M;
            foreach (var registros in Registros)
            {
                soma += soma + registros.Valor;
            }
            return soma;
        }

        public void CalcularSaldo()
        {
            Console.WriteLine($"Saldo: {CalcularSaldoEntradas() - CalcularSaldoSaidas()}");
        }
    }
}
