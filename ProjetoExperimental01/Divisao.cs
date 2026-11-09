using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01
{
    interface IDivisao
    {
        double Valor01 { get; set; }
        double Valor02 { get; set; }
    }
    internal class Divisao : IDivisao
    {
        private double _valor01;
        private double _valor02;
        public double Valor01
        {
            get => _valor01;
            set => _valor01 = value;
        }
        public double Valor02
        {
            get => _valor02;
            set => _valor02 = value;
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-- Divisão de dois números --");
                Console.WriteLine("Digite o primeiro valor:");
                if (!double.TryParse(Console.ReadLine(), out double numero01) || numero01 == 0)
                {
                    Console.WriteLine("Digite um número válido.");
                    continue;
                }
                Console.WriteLine("Digite o segundo valor:");
                if (!double.TryParse(Console.ReadLine(), out double numero02) || numero02 == 0)
                {
                    Console.WriteLine("Digite um número válido diferente de 0.");
                    continue;
                }
                Divisao divisores = new Divisao
                {
                    Valor01 = numero01,
                    Valor02 = numero02
                };

                double resultado = divisores.Valor01 / divisores.Valor02;
                Console.WriteLine("O resultado da divisão é: " + resultado);
                break;
            }
        }
    }
}


