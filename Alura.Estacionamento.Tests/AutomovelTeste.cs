using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class AutomovelTeste
    {
        [Fact(Skip = "Teste ainda não implementado")]
        public void ValidaPropriedadeProprietarioAutomovel()
        {
            // Exemplo de utilização do Skip
        }

        [Fact]
        public void DadosAutomovel()
        {
            //Arrange
            var carro = new Automovel();
            carro.Proprietario = "Carlos Silva";
            carro.Placa = "ZAP-7419";
            carro.Cor = "Verde";
            carro.Modelo = "Variante";     

            //Act
            string dados = carro.ToString();

            //Assert
            Assert.Contains("Tipo do Veículo: Automóvel", dados);


        }
    }
}
