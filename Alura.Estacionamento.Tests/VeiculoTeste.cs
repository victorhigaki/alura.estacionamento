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

        [Fact]
        public void AlteraDadosVeiculo()
        {
            //Arrange
            Patio estacionamento = new Patio();
            var veiculo = new Automovel();
            veiculo.Proprietario = "José Silva";
            veiculo.Placa = "ZXC-8524";
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Opala";     
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Automovel();
            veiculoAlterado.Proprietario = "José Silva";
            veiculoAlterado.Placa = "ZXC-8524";
            veiculoAlterado.Cor = "Preto"; //Alterado
            veiculoAlterado.Modelo = "Opala";


            //Act
            var alterado = estacionamento.AlteraDadosVeiculo(veiculoAlterado);

            //Assert
            Assert.Equal(alterado.Cor,veiculoAlterado.Cor);

        }
    }
}
