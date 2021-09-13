using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTeste
    {
        public ITestOutputHelper Output { get; }
        private Veiculo veiculo;
    
        public VeiculoTeste(ITestOutputHelper output)
        {
            Output = output;
            Output.WriteLine("Execução do  construtor.");
            veiculo = new Veiculo();
            veiculo.Tipo = TipoVeiculo.Automovel;
        }

        [Fact]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerarComAceleracao10()
        {
            //Arrange
            //var veiculo = new Veiculo();

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
            //var veiculo = new Veiculo();

            //Act
            veiculo.Freiar(10);
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaAlteraDadosVeiculoDeUmDeterminadoVeiculoComBaseNaPlaca()
        {
            //Arrange

            Patio estacionamento = new Patio();        
            var veiculo = new Veiculo();
            veiculo.Proprietario = "José Silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Placa = "ZXC-8524";
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Opala";     
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Veiculo();
            veiculoAlterado.Proprietario = "José Silva";
            veiculoAlterado.Tipo = TipoVeiculo.Automovel;
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
