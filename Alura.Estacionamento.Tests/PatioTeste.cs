using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class PatioTeste
    {
        [Fact]
        public void ValidaFaturamento()
        {
            //Arranje
            Patio estacionamento = new Patio();
            var veiculo = new Automovel();
            veiculo.Proprietario = "André Silva";
            veiculo.Placa = "ABC-0101";
            veiculo.Modelo = "Fusca";
            veiculo.QtdePortas = 2;            
            veiculo.Acelerar(10);
            veiculo.Freiar(5);
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2,faturamento);
        }
    }
}
