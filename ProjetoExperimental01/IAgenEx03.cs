using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoExperimental01
{
    public abstract class BancoDeTalentos
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        protected BancoDeTalentos()
        {
            
        }
    }
    public class Candidato : BancoDeTalentos
    {
        public string Nome { get; private set; }
        public DateOnly DataDeNascimento { get; private set; }
        public string Cpf { get; private set; }
        public string CursoDeInteresse { get; private set; }
        public Candidato(string _nome, DateOnly _dataDeNascimento, string _cpf, string _cursoDeInteresse)
        {
            Nome = _nome;
            DataDeNascimento = _dataDeNascimento;
            Cpf = _cpf;
            CursoDeInteresse = _cursoDeInteresse;
        }

    }
    public class IAgenEx03
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
