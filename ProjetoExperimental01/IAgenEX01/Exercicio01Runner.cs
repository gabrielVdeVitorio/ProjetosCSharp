using ProjetoExperimental01.IAgenEX01.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01.IAgenEX01
{
    internal class Exercicio01Runner
    {
        public static void Main(string[] args)
        {
            try
            {
                Candidato candidato = new Candidato();
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
                    catch (ArgumentException ex)
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
