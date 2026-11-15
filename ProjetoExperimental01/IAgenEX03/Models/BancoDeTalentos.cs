using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01.IAgenEX03.Models
{
    public abstract class BancoDeTalentos
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        protected BancoDeTalentos()
        {

        }
    }
}
