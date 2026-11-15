using ProjetoExperimental01.IAgenEX03.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01.IAgenEX03
{
    
    
    public class Exercicio03Runner
    {
        public static void Main(string[] args)
        {
            var candidatos = new List<Candidato>
            {
                new Candidato("Gabriel Vitório", new DateOnly(2000, 02, 24), "01234567890", "Desenvolvimento web em C#.NET"),
                new Candidato("Caio de Lima Oliveira", new DateOnly(2005, 05, 14), "09876543210", "Desenvolvimento web em Java"),
                new Candidato("Gabriel Marinho", new DateOnly(2005, 08, 18), "19283746503", "Desenvolvimento mobile em Kotlin")
            }.ToDictionary(Candidato => Candidato.Cpf);
            Console.WriteLine(candidatos["01234567890"].Nome);
        }
    }
}
