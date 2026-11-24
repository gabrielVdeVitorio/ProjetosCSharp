using System;
using System.Collections.Generic;
using System.Text;
using ProjetoExperimental01.IAgenEX03.Records;

namespace ProjetoExperimental01.IAgenEX03.Models
{
    public class Candidato
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Nome { get; private set; }
        public string DataDeNascimento { get; private set; }
        public string Cpf { get; private set; }
        public string CursoDeInteresse { get; private set; }
        public Candidato(string nome, string dataDeNascimento, string cpf, string cursoDeInteresse)
        {
            if ( string.IsNullOrWhiteSpace(nome) ) { throw new ArgumentException("O nome é obrigatório (não pode ser vazio)."); }
            if ( !DateOnly.TryParse(dataDeNascimento, out DateOnly data) ) { throw new ArgumentException("A data digitada não é válida"); }
            if ( data < DateOnly.FromDateTime(DateTime.Today) ) { throw new ArgumentOutOfRangeException("A data de nascimento não pode ser depois de hoje."); }
            if ( data < DateOnly.FromDateTime(DateTime.Today).AddYears(-16) ) { throw new ArgumentOutOfRangeException("A idade não pode ser menor de 16 anos."); }
            if ( cpf.Length != 11 ) { throw new ArgumentOutOfRangeException("O CPF deve ter exatamente 11 dígitos."); }
            if ( cursoDeInteresse.Length != 11 ) { throw new ArgumentOutOfRangeException("O curso de interesse não pode ser vazio."); }
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Cpf = cpf;
            CursoDeInteresse = cursoDeInteresse;
        }

    }
}
