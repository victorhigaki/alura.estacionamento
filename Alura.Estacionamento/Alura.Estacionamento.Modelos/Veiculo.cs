using System;
using System.Collections;
using System.Collections.Generic;

namespace Alura.Estacionamento.Modelos
{
    public class Veiculo
    {
        private string _placa;
        public string Placa
        {
            get
            {
                return _placa;
            }
            set
            {
                // Checa se o valor possui pelo menos 8 caracteres
                if (value.Length != 8)
                {
                    throw new FormatException(" A placa deve possuir 8 caracteres");
                }
                for (int i = 0; i < 3; i++)
                {
                    //checa se os 3 primeiros caracteres são numeros
                    if (char.IsDigit(value[i]))
                    {
                        throw new FormatException("Os 3 primeiro caracteres deve ser letras!");
                    }
                }
                //checa o Hifem
                if (value[3] != '-')
                {
                    throw new FormatException("o Quarto caracter deve ser um Hifem");
                }
                //checa se os 3 primeiros caracteres são numeros
                for (int i = 4; i < 8; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        throw new FormatException("Do 5º ao 8º caractere deve-se ter um número!");
                    }
                }
                _placa = value;

            }
        }
        /// <summary>
        /// { get; set; } cria uma propriedade automática, ou seja,
        /// durante a compilação, é gerado um atributo para armazenar
        /// o valor da propriedade e os metodos get e set, respectivamente,
        /// lêem e escrevem diretamente no atributo gerado, sem
        /// qualquer validação. É um recurso útil, pois as propriedades
        /// permitem fazer melhor uso do recurso de Reflection do .Net
        /// Framework, entre outros benefícios.
        /// </summary>
        public string Cor { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        public double Peso { get; set; }
        public double VelocidadeAtual { get; set; }
        public string Modelo { get; set; }

        private string _proprietario;
        public string Proprietario
        {
            get
            {
                return _proprietario;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new System.FormatException(" Nome de proprietário deve ter no mínimo 3 caracteres.");
                }
                _proprietario = value;
            }

        }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }

        private int _capacidadeTanque;

        public int CapacidadeTanque
        {
            get { return _capacidadeTanque; }
            set { _capacidadeTanque = value; }
        }

        public void Acelerar(int tempoSeg)
        {
            this.VelocidadeAtual += (tempoSeg * 10);
        }

        public void Freiar(int tempoSeg)
        {
            this.VelocidadeAtual -= (tempoSeg * 15);
        }

         public Veiculo()
        {

        }

        public Veiculo(string proprietario)
        {
            Proprietario = proprietario;
        }

    }
}
