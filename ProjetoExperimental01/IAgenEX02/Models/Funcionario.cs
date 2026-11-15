using ProjetoExperimental01.IAgenEX02.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01.IAgenEX02.Models
{
    public abstract class Funcionario
    {
        public string Nome { get; private set; }
        public decimal SalarioBase { get; private set; }
        public NivelSenioridade Senioridade { get; private set; }

        public Funcionario(string nome, decimal salarioBase, NivelSenioridade senioridade)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(nome, nameof(nome));
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(salarioBase, nameof(salarioBase));
            if (!Enum.IsDefined(typeof(NivelSenioridade), senioridade)) { throw new ArgumentOutOfRangeException(nameof(senioridade), "Nível de senioridade inválido"); }
            Nome = nome;
            SalarioBase = salarioBase;
            Senioridade = senioridade;
        }

        public virtual decimal CalcularSalario()
        {

            return Senioridade switch
            {
                NivelSenioridade.Junior => SalarioBase,
                NivelSenioridade.Pleno => SalarioBase * 1.3m,
                NivelSenioridade.Senior => SalarioBase * 1.6m,
                _ => SalarioBase
            };
        }
    }
}
