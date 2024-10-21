using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco.Domain;

namespace ProjetoBanco.Data
{
    public class BancoDados
    {
        public List<Extrato> Extratos { get; set; }
        public List<TipoRegistro> TiposRegistro { get; set; }
        public List<Registro> Registros { get; set; }

        public BancoDados()
        {
            // Simular a criação de alguns dados
            Extratos = new List<Extrato>()
            {
                new Extrato(1, "123456", "João da Silva"),
                new Extrato(2, "654321", "Maria Oliveira")
            };

            TiposRegistro = new List<TipoRegistro>()
            {
                //new TipoRegistro(1, "Depósito"),
                //new TipoRegistro(2, "Retirada")
            };

            Registros = new List<Registro>()
            {
                new Registro(1, 500.00m, 1, 1),
                new Registro(2, 200.00m, 2, 1),
                new Registro(3, 300.00m, 1, 2)
            };

            //INSTANCIAR REGISTROS DE ENTRADA E SAIDA
            


        }
    }
}
