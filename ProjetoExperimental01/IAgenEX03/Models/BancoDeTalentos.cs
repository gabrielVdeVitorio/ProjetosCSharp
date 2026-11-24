using ProjetoExperimental01.IAgenEX03.Interfaces;
using ProjetoExperimental01.IAgenEX03.Records;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ProjetoExperimental01.IAgenEX03.Models
{
    public class BancoDeTalentos : IBancoDeTalentos
    {
        private readonly Dictionary<string, Candidato> _candidatos = new();
        public void AdicionarCandidato(Candidato candidato)
        {
            if ( _candidatos.TryAdd(candidato.Cpf, candidato ) )
            {
                throw new ArgumentException($"Já existe um candidato cadastrado com o CPF {candidato.Cpf}.");
            }
        }
        public Candidato BuscarCandidatoPorCpf(string cpf)
        {
            return _candidatos[cpf];
        }
    }
}
