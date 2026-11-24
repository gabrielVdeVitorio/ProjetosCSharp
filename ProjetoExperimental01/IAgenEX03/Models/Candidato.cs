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
        public DateOnly DataDeNascimento { get; private set; }
        public string Cpf { get; private set; }
        public string CursoDeInteresse { get; private set; }
        public Candidato(CandidatoDto dados)
        {
            if ( string.IsNullOrWhiteSpace(dados.Nome) ) { throw new ArgumentException("O nome é obrigatório (não pode ser vazio)."); }
            if ( !DateOnly.TryParse(dados.DataDeNascimento, out DateOnly data) ) { throw new ArgumentException("A data digitada não é válida"); }
            if ( data < DateOnly.FromDateTime(DateTime.Today) ) { throw new ArgumentOutOfRangeException("A data de nascimento não pode ser depois de hoje."); }
            if ( data < DateOnly.FromDateTime(DateTime.Today).AddYears(-16) ) { throw new ArgumentOutOfRangeException("A idade não pode ser menor de 16 anos."); }
            if ( dados.Cpf.Length != 11 ) { throw new ArgumentOutOfRangeException("O CPF deve ter exatamente 11 dígitos."); }
            if ( dados.CursoDeInteresse.Length != 11 ) { throw new ArgumentOutOfRangeException("O curso de interesse não pode ser vazio."); }
            Nome = dados.Nome;
            DataDeNascimento = data;
            Cpf = dados.Cpf;
            CursoDeInteresse = dados.CursoDeInteresse;
        }

    }
}
