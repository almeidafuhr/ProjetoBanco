using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain
{
    public class TipoEntrada : TipoRegistro
    { 

        public override void DescricaoTipo()
        {
            Console.WriteLine("Entrada!");
        }
    }
}
