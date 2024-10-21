using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain
{
    public class Transacao
    {
        public int ID;
        public decimal Valor;
        public DateTime DataTransacao;
        public string TipoRegistro;

        public Transacao(int id, decimal valor, DateTime dataTransacao)
        {
            ID = id;
            Valor = valor;
            DataTransacao = dataTransacao;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {ID}, Valor: {Valor}, Data: {DataTransacao}");
        }

        public void ValidarTransacao()
        {
            if (Valor < 0)
                throw new ValorInvalidoException("Valor inválido para realizar transação!", nameof(Valor));
        }
    }
}
