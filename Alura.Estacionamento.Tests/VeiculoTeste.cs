using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTeste
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            //Arranje
            var veiculo = new Veiculo();

            //Act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);

        }

        [Fact]
      
        public void TestaNomeProprietarioVeiculo()
        {
            //Arranje 
            string nomeProprietario = "Ab";
            //Assert
            Assert.Throws<System.FormatException>(
                //Act
                () => new Veiculo(nomeProprietario)
            );
        }

        [Fact]
        public void TestaVeiculoFreiar()
        {
            //Arranje
            var veiculo = new Veiculo();
            //Act
            veiculo.Freiar(10);
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }
    }
}
