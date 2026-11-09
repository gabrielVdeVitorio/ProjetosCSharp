using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01
{
    internal class Multiplicacao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-- Multiplicação de dois números --");
            Console.WriteLine("Digite o primeiro valor:");
            string valor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor:");
            string valor2 = Console.ReadLine();
            if (int.TryParse(valor1, out int numero1) && int.TryParse(valor2, out int numero2))
            {
                int resultado = numero1 * numero2;
                Console.WriteLine("O resultado da multiplicação é: " + resultado);
            }
            else
            {
                Console.WriteLine("Por favor, insira valores válidos.");
                Main(args); // Chama novamente o método Main para reiniciar o processo
            }
        }
    }
}

