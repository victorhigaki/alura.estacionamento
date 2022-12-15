using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
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


        [Fact]
        public void DadosVeiculo()
        {
            // Arrange
            var carro = new Veiculo();
            carro.Proprietario = "Carlos Silva";
            carro.Tipo = TipoVeiculo.Automovel;
            carro.Placa = "ZAP-7419";
            carro.Cor = "Verde";
            carro.Modelo = "Variante";

            // Act
            string dados = carro.ToString();

            // Assert
            Assert.Contains("Tipo do Veículo: Automovel", dados);
        }
    }
}
