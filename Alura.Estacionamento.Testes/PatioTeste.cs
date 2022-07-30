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

    }
}
