using Alura.Estacionamento.Modelos;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTeste
    {
   
        [Fact]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerarComAceleracao10()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);

        }
         

        [Fact]
        [Trait("Funcionalidade", "Freiar")]
        public void TestaVeiculoFreiarComFreio10()
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
