using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTeste
    {
        [Fact(DisplayName = "Teste n°1")]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);

        }

        [Fact(DisplayName ="Teste n°2")]
        [Trait("Propriedade", "Proprietário")]
        public void TestaNomeProprietarioVeiculo()
        {
            //Arrange 
            string nomeProprietario = "Ab";
            //Assert
            Assert.Throws<System.FormatException>(
                //Act
                () => new Veiculo(nomeProprietario)
            );
        }

        [Fact(DisplayName = "Teste n°3")]
        [Trait("Funcionalidade", "Freiar")]
        public void TestaVeiculoFreiar()
        {
            //Arrange
            var veiculo = new Veiculo();
            //Act
            veiculo.Freiar(10);
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        
    }
}
