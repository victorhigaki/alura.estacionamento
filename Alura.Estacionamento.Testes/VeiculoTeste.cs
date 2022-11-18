using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTeste
    {
        [Fact(DisplayName = "Teste nº1")]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            // Arrange
            var veiculo = new Veiculo();
            // Act
            veiculo.Acelerar(15);
            // Assert
            Assert.Equal(150, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "Teste nº2")]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrear()
        {
            // Arrange
            var veiculo = new Veiculo();
            // Act
            veiculo.Frear(10);
            // Assert            
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "Teste nº3", Skip = "Teste ainda não implementado. Ignorar")]
        public void ValidaNomeProprietario()
        {

        }
    }
}
