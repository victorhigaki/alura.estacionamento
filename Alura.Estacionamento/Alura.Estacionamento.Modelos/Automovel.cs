using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Estacionamento.Modelos
{
    public class Automovel : Veiculo
    {
        private int ocupantes;
        private int volumePortaMalas;
        private int qtdePortas;

        public int Ocupantes { get => ocupantes; set => ocupantes = value; }
        public int VolumePortaMalas { get => volumePortaMalas; set => volumePortaMalas = value; }
        public int QtdePortas { get => qtdePortas; set => qtdePortas = value; }

        public override string ToString()
        {
            return $"Ficha do Veículo:\n " +
                    $"Tipo do Veículo: Automóvel\n " +
                    $"Proprietário: {this.Proprietario}\n" +
                    $"Modelo: {this.Modelo}\n" +
                    $"Cor: {this.Cor}\n" +
                    $"Placa: {this.Placa}\n" +
                    $"Capacidade Tanque: {this.CapacidadeTanque}\n" +
                    $"Comprimento: {this.Comprimento}\n" +
                    $"Largura: {this.Largura}\n" +
                    $"Peso: {this.Peso}\n" +
                    $"Ocupantes: {this.Ocupantes}\n" +
                    $"Volume Porta Malas: {this.VolumePortaMalas}\n" +
                    $"Quantidade de Portas: {this.QtdePortas}\n";                    
        }

        public override void AlteraDados(Veiculo veiculoAlterado)
        {
            var _automovel = (Automovel)veiculoAlterado;
            base.AlteraDados(veiculoAlterado);
            this.Ocupantes = _automovel.Ocupantes;
            this.volumePortaMalas = _automovel.VolumePortaMalas;
            this.QtdePortas = _automovel.QtdePortas;

        }
    }

   

}
