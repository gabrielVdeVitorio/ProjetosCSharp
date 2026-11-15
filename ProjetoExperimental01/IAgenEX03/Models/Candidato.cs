using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01.IAgenEX03.Models
{
    public class Candidato : BancoDeTalentos
    {
        public string Nome { get; private set; }
        public DateOnly DataDeNascimento { get; private set; }
        public string Cpf { get; private set; }
        public string CursoDeInteresse { get; private set; }
        public Candidato(string nome, DateOnly _dataDeNascimento, string _cpf, string _cursoDeInteresse)
        {
            Nome = nome;
            DataDeNascimento = _dataDeNascimento;
            Cpf = _cpf;
            CursoDeInteresse = _cursoDeInteresse;
        }

    }
}
