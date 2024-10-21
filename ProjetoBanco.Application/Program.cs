using System;
using Serilog;
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

            try
            {
                Registro reg = new Registro(10,500,3,100);
                
                
            }
            catch (TipoRegistroInvalidoException ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
            }
            TipoEntrada tipo = new TipoEntrada();
            tipo.ID = 1;
            Console.WriteLine($"{tipo.ID} - {tipo.Tipo}");


            
            //LOGS
            // Configurando o Serilog para escrever logs em um arquivo texto
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()  // Definindo o nível mínimo de log
                .WriteTo.File("C:\\Users\\E37083\\Desktop\\Atividades\\Projeto\\ProjetoBanco.Application\\ProjetoBanco.Application\\Logs\\log.txt",
                    rollingInterval: RollingInterval.Day,   // Novo arquivo por dia
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}")  // Formato da mensagem
                .CreateLogger();

            try
            {
                Log.Information("Aplicação iniciada");

                // Simulação de execução da aplicação
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                {
                    throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo ou vazio");
                }

                Log.Information("Nome informado: {Nome}", nome);

                Console.WriteLine($"Olá, {nome}!");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ocorreu um erro inesperado");
            }
            finally
            {
                Log.Information("Aplicação finalizada");
                Log.CloseAndFlush();
            }




        Console.ReadKey();
        }
    }
}
