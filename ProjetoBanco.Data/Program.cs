using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco.Domain;
using ProjetoBanco.Data;
using ProjetoBanco.Domain.Exceptions;

namespace ProjetoBanco.Application
{
    class Program
    {
        public static bool VerificarConta(BancoDados banco, string conta)
        {
            bool verifica = false;
            foreach (var numeroConta in banco.Extratos)
            {
                if (numeroConta.NumeroConta.Equals(conta))
                {
                    verifica = true;
                    break;
                }
            }
            return verifica;
        }

        public static string GerarNumeroConta(BancoDados banco)
        {
            Random rand = new Random();
            string conta;
            do
            {
                //conta = rand.Next(1000000000).ToString();  
                conta = "123456";

            } while (VerificarConta(banco, conta));
            return conta;
        }

        public static void AdicionarRegistros(BancoDados banco)
        {
            int op;
            Console.Write("\nDigite:\n1 - Inserir novos extratos; \n2 - Inserir novos tipos de registro;\nEscolha: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Inserir Novo Registro de Extrato...");
                    int id = banco.Extratos.Count + 1;
                    Console.WriteLine($"ID: {id}");
                    string numeroConta = GerarNumeroConta(banco);
                    Console.WriteLine($"Numero da Conta: {numeroConta}");
                    Console.Write("Seu nome:");
                    string nome = Console.ReadLine();
                    banco.Extratos.Add(new Extrato(id, numeroConta, nome));
                    
                    break;
                case 2:
                    Console.WriteLine("Inserir Novo Tipo de Registro");
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            BancoDados banco = new BancoDados();

            // Exibir todos os extratos
            Console.WriteLine("Extratos Bancários:");
            foreach (var extrato in banco.Extratos)
            {
                extrato.ExibirDetalhes();
            }

            Console.WriteLine("\nRegistros:");
            foreach (var registro in banco.Registros)
            {
                registro.ExibirDetalhes();
            }

            //AdicionarRegistros(banco);



            Console.ReadKey();
        }
    }
}
