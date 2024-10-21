using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco.Domain.Exceptions;

namespace ProjetoBanco.Domain
{
    public abstract class TipoRegistro
    {
        public int ID { get; set; }
        public string Tipo { get; set; }

        //Um construtor padrão que inicializa o tipo como "Desconhecido".
        public TipoRegistro() : this(0, "Desconhecido") { }

        //Um construtor que aceita apenas o tipo e atribui um ID padrão de 0.
        public TipoRegistro(string tipo) : this(0, tipo) { }

        //Um construtor que aceita o ID e o Tipo.
        public TipoRegistro(int id, string tipo)
        {
            ID = id;
            Tipo = tipo;
        }

        public void exibirTipo()
        {
            Console.WriteLine($"ID: {ID}, Tipo: {Tipo}");
        }

        public abstract void DescricaoTipo();

    }
}
