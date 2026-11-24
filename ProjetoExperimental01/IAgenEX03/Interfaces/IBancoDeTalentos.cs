using ProjetoExperimental01.IAgenEX03.Records;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01.IAgenEX03.Interfaces
{
    internal interface IBancoDeTalentos
    {
        void AdicionarCandidato(CandidatoDto candidato);
    }
}
