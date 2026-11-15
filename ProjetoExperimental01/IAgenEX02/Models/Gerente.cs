using ProjetoExperimental01.IAgenEX02.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01.IAgenEX02.Models
{
    public class Gerente : Funcionario
    {
        public int TamanhoEquipe { get; private set; }
        public Gerente(string nome, decimal salarioBase, NivelSenioridade senioridade, int tamanhoEquipe)
            : base(nome, salarioBase, senioridade)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(tamanhoEquipe, nameof(tamanhoEquipe));
            TamanhoEquipe = tamanhoEquipe;
        }
        public override decimal CalcularSalario()
        {
            decimal salarioBaseComSenioridade = base.CalcularSalario();
            return salarioBaseComSenioridade * 1.20m;
        }
    }
}
