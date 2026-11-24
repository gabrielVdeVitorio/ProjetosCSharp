using ProjetoExperimental01.IAgenEX02.Enums;
using ProjetoExperimental01.IAgenEX02.Models;
using Xunit;

namespace ProjetoExperimental01.Tests.IAgenEX02.Models
{
    public class FuncionarioTests
    {
        private class FuncionarioDummy : Funcionario
        {
            public FuncionarioDummy(string nome, decimal salarioBase, NivelSenioridade senioridade)
                : base(nome, salarioBase, senioridade)
            {
                
            }
        }
        [Theory]
        [InlineData("")]
        [InlineData("    ")]
        [InlineData(null)]
        public void Funcionario_ComNomeInvalido_DeveLancarArgumentException(string? nomeInvalido)
        {
            // Act & Assert
            Assert.ThrowsAny<ArgumentException>(() => new FuncionarioDummy(nomeInvalido!, 4000m, NivelSenioridade.Junior));
        }
        [Theory]
        [InlineData(0)]
        [InlineData(-200)]
        public void Funcionario_ComSalarioBaseInvalido_DeveLancarArgumentOutOfRangeException(decimal salarioBaseInvalido)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new FuncionarioDummy("João Miguel", salarioBaseInvalido, NivelSenioridade.Pleno));
        }
        [Fact]
        public void Funcionario_ComNivelDeSenioridadeInvalido_DeveLancarOutOfRangeException()
        {
            // Arrange
            var senioridadeInexistente = (NivelSenioridade)99;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new FuncionarioDummy("João Miguel", 4000m, senioridadeInexistente));
        }
    }
}
