using ProjetoExperimental01.IAgenEX03.Models;
using ProjetoExperimental01.IAgenEX03.Records;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01.IAgenEX03
{
    
    
    public class Exercicio03Runner
    {
        public static void Main(string[] args)
        {
            var candidatos = new List<CandidatoDto>
            {
                new CandidatoDto("Gabriel Vitório", "24-02-2000", "01234567890", "Desenvolvimento web em C#.NET"),
                new CandidatoDto("Caio de Lima Oliveira", "14-05-2005", "09876543210", "Desenvolvimento web em Java"),
                new CandidatoDto("Gabriel Marinho", "18-08-2002", "19283746503", "Desenvolvimento mobile em Kotlin")
            }.ToDictionary(Candidato => Candidato.Cpf);
            Console.WriteLine(candidatos["01234567890"].Nome);
        }
    }
}
