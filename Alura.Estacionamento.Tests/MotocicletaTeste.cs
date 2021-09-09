using Alura.Estacionamento.Modelos;
using Xunit;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Tests
{
    public class MotocicletaTeste
    {
        private Motocicleta moto = new Motocicleta();
        //Classe do xUnit para trabalharmos com saídas no console de teste.
        public ITestOutputHelper Output { get; }
        public MotocicletaTeste(ITestOutputHelper output)
        {
            Output = output;
            Output.WriteLine("Execução do  construtor.");

            var moto = new Motocicleta();
            moto.Proprietario = "Andressa Silva";
            moto.Placa = "ZAP-7419";
            moto.Cor = "Verde";
            moto.Modelo = "Yamaha";
            moto.Cilindradas = 500;
            moto.Cor = "Amarela";
            
        }


        [Fact]
        public void ExibeDadosdaPropriaMotocicletaEstacionadaNoPatio()
        {
            //Arrange
            //var moto = new Motocicleta();
            //moto.Proprietario = "Andressa Silva";
            //moto.Placa = "ZAP-7419";
            //moto.Cor = "Verde";
            //moto.Modelo = "Yamaha";
            //moto.Cilindradas = 500;
            //moto.Cor = "Amarela";

            //Act
            string dados = moto.ToString();

            //Assert
            Assert.Contains("Tipo do Veículo: Motocicleta", dados);
            

        }
    }
}
