using ProjetoExperimental01.IAgenEX02.Models;
using ProjetoExperimental01.IAgenEX02.Enums;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjetoExperimental01.IAgenEX02
{
    internal class Exercicio02Runner
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
