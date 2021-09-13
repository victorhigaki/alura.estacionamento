using Alura.Estacionamento.Modelos;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTeste
    {
       
        [Fact]   
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
