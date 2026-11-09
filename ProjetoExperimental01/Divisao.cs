using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01
{
    internal class Divisao
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-- Divisão de dois números --");
                Console.WriteLine("Digite o primeiro valor:");
                string valor01 = Console.ReadLine();
                Console.WriteLine("Digite o segundo valor:");
                string valor02 = Console.ReadLine();
                if (!int.TryParse(valor01, out int numero01) || !int.TryParse(valor02, out int numero02) || numero02 == 0)
                {
                    Console.WriteLine("Por favor, insira valores válidos e certifique-se de que o segundo número não seja zero.");
                    continue;
                }
                double resultado = (double)numero01 / numero02;
                Console.WriteLine("O resultado da divisão é: " + resultado);
                break;
            }
        }
    }
}

