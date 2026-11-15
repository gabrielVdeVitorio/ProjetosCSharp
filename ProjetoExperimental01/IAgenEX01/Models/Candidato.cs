using ProjetoExperimental01.IAgenEX01.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01.IAgenEX01.Models
{
    public class Candidato : ICandidato
    {
        private string nome;
        private int idade;
        public string Nome
        {
            get => nome;
            set => nome = value.Length < 1 ? throw new ArgumentException("Nome não pode ser vazio") : value.Trim();
        }

        public int Idade
        {
            get => idade;
            set => idade = value < 14 ? throw new ArgumentException("Idade não pode ser menor do que 14 anos") : value;
        }
    }
}
