using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01
{
    interface ICandidato
    {
        string Nome { get; set; }
        int Idade { get; set; }
    }

    public class IAgenEX01: ICandidato
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome;
            set => _nome = value.Length < 1 ? throw new ArgumentException("Nome não pode ser vazio") : value.Trim();
        }

        public int Idade
        {
            get => _idade;
            set => _idade = value < 14 ? throw new ArgumentException("Idade não pode ser menor do que 14 anos") : value;
        }

        public static void Main(string[] args)
        {
            try
            {
                IAgenEX01 candidato = new IAgenEX01();
                Console.WriteLine("-- Cadastro de Candidato --");
                Console.WriteLine("Digite o nome do candidato:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do candidato:");
                while (true)
                {
                    try
                    {
                        string idadeInput = Console.ReadLine();
                        if (!int.TryParse(idadeInput, out int idade))
                        {
                            throw new ArgumentException("Idade deve ser um número inteiro maior do que ou igual a zero.");
                        }

                        candidato.Nome = nome;
                        candidato.Idade = idade;

                        break;
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}\n");
                        Console.WriteLine("Digite a idade do candidato novamente:");
                    }
                }
                Console.WriteLine($"Candidato cadastrado com sucesso: Nome - {candidato.Nome}, Idade - {candidato.Idade}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }
    }
}
