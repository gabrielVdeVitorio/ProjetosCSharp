using ProjetoExperimental01.IAgenEX02.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01.IAgenEX02.Models
{
    public class Desenvolvedor : Funcionario
    {
        public string PrincipaisLinguagens { get; set; }
        public Desenvolvedor(string nome, decimal salarioBase, NivelSenioridade senioridade, string principaisLinguagens)
            : base(nome, salarioBase, senioridade)
        {
            PrincipaisLinguagens = principaisLinguagens;
        }
    }
}
