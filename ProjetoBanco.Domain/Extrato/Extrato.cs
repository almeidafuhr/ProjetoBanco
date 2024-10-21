using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain
{
    public class Extrato
    {
        public int ID { get; set; }
        public string NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public List<Transacao> Registros { get; private set; }

        public Extrato(int id, string numeroConta, string nomeTitular)
        {
            ID = id;
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {ID}, Conta: {NumeroConta}, Titular: {NomeTitular}");
        }

        public void ValidarNumeroConta()
        {
            if (string.IsNullOrEmpty(NumeroConta))
            {
                throw new ExtratoInvalidoException("O número da conta é inválido.", nameof(NumeroConta));
            }
        }

        public void ImprimirExtrato()
        {

        }

    }
}
