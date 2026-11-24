using System;
using System.Collections.Generic;
using System.Text;
using ProjetoExperimental01.IAgenEX01.Interfaces;

namespace ProjetoExperimental01.IAgenEX01.Models
{
    

    public class Candidato: ICandidato
    {
        private string _nome = string.Empty;
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
    }
}
