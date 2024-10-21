using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain
{
    public class RegistroEntrada : Transacao
    {
        public RegistroEntrada(int ID, decimal Valor, DateTime DataTransacao, string TipoRegistro) : base(ID, Valor, DataTransacao)
        {
            TipoRegistro = "Entrada";
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {ID}, Valor: {Valor}, Data: {DataTransacao}, Tipo: {TipoRegistro}");
        }
    }
}
