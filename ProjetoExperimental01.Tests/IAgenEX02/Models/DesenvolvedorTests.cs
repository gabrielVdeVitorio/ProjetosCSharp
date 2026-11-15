using ProjetoExperimental01.IAgenEX02.Enums;
using ProjetoExperimental01.IAgenEX02.Models;
using Xunit;

namespace ProjetoExperimental01.Tests.IAgenEX02.Models
{
    public class DesenvolvedorTests
    {
        [Theory]
        [InlineData(NivelSenioridade.Junior, 5000, 5000)] // 5000 * 1.0
        [InlineData(NivelSenioridade.Pleno, 5000, 6500)]  // 5000 * 1.3
        [InlineData(NivelSenioridade.Senior, 5000, 8000)] // 5000 * 1.6
        public void Gerente_DeveCalcularSalarioComSenioridadeE20PorcentoDeBonus
        (
            NivelSenioridade senioridade,
            decimal salarioBase,
            decimal salarioEsperado
        )
        {
            // Arrange
            var dev = new Desenvolvedor("Emilly Ribeiro Cardoso", salarioBase, senioridade, "C#, TypeScript");

            // Act
            decimal salarioCalculado = dev.CalcularSalario();

            // Assert
            Assert.Equal(salarioEsperado, salarioCalculado);
        }
        [Theory]
        [InlineData("")]
        [InlineData("    ")]
        [InlineData(null)]
        public void Desenvolvedor_DeveTerLinguagemPrincipal_LancarArgumentException(string? linguagemInvalida)
        {
            // Act & Assert
            Assert.ThrowsAny<ArgumentException>(() => new Desenvolvedor("Emilly Ribeiro Cardoso", 3000m, NivelSenioridade.Junior, linguagemInvalida!));
        }
    }
}
