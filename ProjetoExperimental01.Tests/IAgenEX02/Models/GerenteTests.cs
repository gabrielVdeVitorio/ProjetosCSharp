using ProjetoExperimental01.IAgenEX02.Enums;
using ProjetoExperimental01.IAgenEX02.Models;
using Xunit;

namespace ProjetoExperimental01.Tests.IAgenEX02.Models;

public class GerenteTestes
{
    [Theory]
    [InlineData(NivelSenioridade.Junior, 5000, 6000)] // 5000 * 1.0 * 1.2
    [InlineData(NivelSenioridade.Pleno, 5000, 7800)]  // 5000 * 1.3 * 1.2
    [InlineData(NivelSenioridade.Senior, 5000, 9600)] // 5000 * 1.6 * 1.2
    public void Gerente_DeveCalcularSalarioComSenioridadeE20PorcentoDeBonus
        (
            NivelSenioridade senioridade,
            decimal salarioBase,
            decimal salarioEsperado
        )
    {
        // Arrange
        var gerente = new Gerente("Emilly Ribeiro Cardoso", salarioBase, senioridade, 5);

        // Act
        decimal salarioCalculado = gerente.CalcularSalario();

        // Assert
        Assert.Equal(salarioEsperado, salarioCalculado);
    }
    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void Gerente_DeveTerEquipeMaiorDoQue0_LancarArgumentOutOfRangeException(int tamanhoDaEquipeInvalido)
    {
        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Gerente("Emilly Ribeiro Cardoso", 5000m, NivelSenioridade.Senior, tamanhoDaEquipeInvalido));
    }
}
