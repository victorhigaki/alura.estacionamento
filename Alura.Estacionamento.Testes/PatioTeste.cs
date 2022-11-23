 using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class PatioTeste
    {
        [Fact]
        public void TestarFaturamento()
        {
            // Arrange
            var estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Placa = "asd-9999";

            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            // ACT
            double faturamento = estacionamento.TotalFaturado();

            // ASSERT
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("André Slva", "ASD-1498", "Preto", "Gol")]
        [InlineData("Jose Slva", "POL-9242", "Cinza", "Fusca")]
        [InlineData("Maria Slva", "GDR-6524", "Azul", "Opala")]
        [InlineData("Pedro Slva", "GDR-0101", "Azul", "Corsa")]
        public void ValidaFaturamentoComVariosVeiculos(string proprietario,
                                                        string placa,
                                                        string cor,
                                                        string modelo)
        {
            // Arrange
            var estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            // Act
            var faturamento = estacionamento.TotalFaturado();

            // Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("André Slva", "ASD-1498", "Preto", "Gol")]
        public void LocalizaVeiculoNoPatio(string proprietario,
                                           string placa,
                                           string cor,
                                           string modelo)
        {
            // Arrange
            var estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            // Act
            var consultado = estacionamento.PesquisaVeiculo(placa);

            // Assert
            Assert.Equal(placa, consultado.Placa);
        }
    }
}
