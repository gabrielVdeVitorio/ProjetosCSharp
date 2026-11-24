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
        private readonly Dictionary<string, CandidatoDto> _candidatos = new();
        public void AdicionarCandidato(CandidatoDto candidato)
        {
            if ( _candidatos.TryAdd(candidato.Cpf, candidato ) )
            {
                throw new ArgumentException($"Já existe um candidato cadastrado com o CPF {candidato.Cpf}.");
            }
        }
        public Candidato BuscarCandidatoPorCpf()
        {

        }
        protected BancoDeTalentos()
        {

        }
    }
}
