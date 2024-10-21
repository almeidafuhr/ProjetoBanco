using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco.Domain.Exceptions;

namespace ProjetoBanco.Domain
{
    public class Registro
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public int TipoID { get; set; }
        public int ExtratoID { get; set; }

        public Registro(int id, decimal valor, int tipoId, int extratoId)
        {
            ID = id;
            Valor = valor;
            TipoID = tipoId;
            ExtratoID = extratoId;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {ID}, Valor: {Valor}, TipoID: {TipoID}, ExtratoID: {ExtratoID}");
        }

        public void ValidarValor()
        {
            if (Valor < 0)
            {
                throw new RegistroInvalidoException("O valor do registro não pode ser negativo.");
            }
        }

        public void ValidarTipo(TipoRegistro tipo)
        {
            if(tipo.ID != 1 || tipo.ID != 2)
            {
                throw new TipoRegistroInvalidoException("Tipo de Registro Inválido! ");
            }
        }

    }
}
