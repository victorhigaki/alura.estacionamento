﻿using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class PatioTeste
    {
        [Fact]
        public void ValidaFaturamentoDeSomenteUmVeiculoPatio()
        {
            //Arranje
            Patio estacionamento = new Patio();
            var operador  = new Operador();
            operador.Nome = "Operador Noturno";
            estacionamento.OperadorPatio = operador;

            var veiculo = new Veiculo();
            veiculo.Proprietario = "André Silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Placa = "ABC-0101";
            veiculo.Modelo = "Fusca";    
            veiculo.Acelerar(10);
            veiculo.Freiar(5);
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("André Silva", "ASD-1498", "preto", "Gol")]
        [InlineData("Jose Silva", "POL-9242", "Cinza", "Fusca")]
        [InlineData("André Silva", "GDR-6524", "Azul", "Opala")]
        [InlineData("André Silva", "OKU-1498", "Amarelo", "HB20")]
        [InlineData("André Silva", "QWZ-5154", "Verde", "Santana")]
        [InlineData("André Silva", "PLU-8472", "Branco", "Logan")]
        public void ValidaFaturamentoComVariosVeiculosNoPatio(string proprietario,
                                                        string placa,
                                                        string cor,
                                                        string modelo)
        {
            //Arranje
            Patio estacionamento = new Patio();
            var operador = new Operador();
            operador.Nome = "Operador Noturno";
            estacionamento.OperadorPatio = operador;

            var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Acelerar(10);
            veiculo.Freiar(5);
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("André Silva", "ASD-1498", "preto", "Gol")]
        public void LocalizaVeiculoNoPatioComBaseNaPlaca(string proprietario,
                                           string placa,
                                           string cor,
                                           string modelo)
        {
            //Arrange
            Patio estacionamento = new Patio();
            var operador = new Operador();
            operador.Nome = "Operador Noturno";
            estacionamento.OperadorPatio = operador;
            var veiculo = new Veiculo();
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Acelerar(10);
            veiculo.Freiar(5);
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            //Act
            var consultado = estacionamento.PesquisaVeiculoPorPlaca(placa);

            //Assert
            Assert.Equal(placa, consultado.Placa);
        }

        [Theory]
        [InlineData("André Silva", "ASD-1498", "preto", "Gol")]
        public void LocalizaVeiculoNoPatioComBaseNoTicket(string proprietario,
                                          string placa,
                                          string cor,
                                          string modelo)
        {
            //Arrange
            Patio estacionamento = new Patio();
            var operador = new Operador();
            operador.Nome = "Operador Noturno";
            estacionamento.OperadorPatio = operador;

            var veiculo = new Veiculo();
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Acelerar(10);
            veiculo.Freiar(5);
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            //Act
            var consultado = estacionamento.PesquisaVeiculoPorTicket(veiculo.IdTicket);

            //Assert
            Assert.Equal(placa, consultado.Placa);
        }

    }
}
