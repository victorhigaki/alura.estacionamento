using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class MotocicletaTeste
    {
        [Fact]
        public void DadosMotocicleta()
        {
            //Arrange
            var moto = new Motocicleta();
            moto.Proprietario = "Andressa Silva";
            moto.Placa = "ZAP-7419";
            moto.Cor = "Verde";
            moto.Modelo = "Yamaha";
            moto.Cilindradas = 500;
            moto.Cor = "Amarela";

            //Act
            string dados = moto.ToString();

            //Assert
            Assert.Contains("Tipo do Veículo: Motocicleta", dados);
            

        }
    }
}
