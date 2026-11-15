using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjetoExperimental01
{
    internal interface IFuncionario
    {
    }
    public enum NivelSenioridade
    {
        Junior,
        Pleno,
        Senior
    }
    public class Funcionario: IFuncionario
    {
        public string Nome { get; set; }
        public decimal SalarioBase { get; set; }
        public NivelSenioridade Senioridade { get; set; }
       
        public Funcionario(string _nome, decimal _salarioBase, NivelSenioridade _senioridade)
        {
            Nome = _nome;
            SalarioBase = _salarioBase;
            Senioridade = _senioridade;
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
    public class Desenvolvedor : Funcionario
    {
        public string PrincipaisLinguagens { get; set; }
        public Desenvolvedor(string _nome, decimal _salarioBase, NivelSenioridade _senioridade, string _principaisLinguagens)
            : base(_nome, _salarioBase, _senioridade)
        {
            PrincipaisLinguagens = _principaisLinguagens;
        }
    }

    public class Gerente : Funcionario
    {
        public int TamanhoEquipe { get; set; }
        public Gerente(string _nome, decimal _salarioBase, NivelSenioridade _senioridade, int _tamanhoEquipe)
            : base(_nome, _salarioBase, _senioridade)
        {
            TamanhoEquipe = _tamanhoEquipe;
        }
        public override decimal CalcularSalario()
        {
            decimal salarioBaseComSenioridade = base.CalcularSalario();
            return salarioBaseComSenioridade * 1.20m;
        }
    }
    public class IAgenEX02
    {
        public static void Main(string[] args)
        {
            var funcionarios = new List<Funcionario>
            {
                new Desenvolvedor("Alice", 3000m, NivelSenioridade.Junior, "C#, Java"),
                new Desenvolvedor("Bob", 4000m, NivelSenioridade.Pleno, "Python, JavaScript"),
                new Gerente("Charlie", 5000m, NivelSenioridade.Senior, 5)
            };

            Console.WriteLine("-- Folha de Pagamento--");
            foreach (var funcionario in funcionarios)
            {
                Console.Write($"Nome: {funcionario.Nome} | Cargo: {funcionario.GetType().Name} | R$ {funcionario.CalcularSalario():F2}");
                PropertyInfo[] Properties = funcionario.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
                foreach (var Property in Properties)
                {
                    Console.Write($" | {Property.Name}: {Property.GetValue(funcionario)}");
                }
                Console.Write("\n");
            }
        }
    }
}
