using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Estacionamento.Modelos
{
    public class Motocicleta:Veiculo
    {
        private int cilindradas;
        private bool temFreioDisco;
        private bool temPortaCapacete;
        private bool temPartidaEletrica;

        public int Cilindradas { get => cilindradas; set => cilindradas = value; }
        public bool TemFreioDisco { get => temFreioDisco; set => temFreioDisco = value; }
        public bool TemPortaCapacete { get => temPortaCapacete; set => temPortaCapacete = value; }
        public bool TemPartidaEletrica { get => temPartidaEletrica; set => temPartidaEletrica = value; }

        public override string ToString()
        {
            return  $"Ficha do Veículo:\n " +
                    $"Tipo do Veículo: Motocicleta\n " +
                    $"Proprietário: {this.Proprietario}\n" +
                    $"Modelo: {this.Modelo}\n" +
                    $"Cor: {this.Cor}\n" +
                    $"Placa: {this.Placa}\n" +
                    $"Capacidade Tanque: {this.CapacidadeTanque}\n" +
                    $"Comprimento: {this.Comprimento}\n" +
                    $"Largura: {this.Largura}\n" +
                    $"Peso: {this.Peso}\n" +
                    $"Cilindradas: {this.Cilindradas}\n" +
                    $"Freio de Disco: {this.TemFreioDisco}\n" +
                    $"Porta Capacete: {this.TemPortaCapacete}\n" +
                    $"Partida Elétrica: {this.TemPartidaEletrica}\n";            
        }

        public override void AlteraDados(Veiculo veiculoAlterado)
        {
            var _motocicleta = (Motocicleta)veiculoAlterado;
            base.AlteraDados(veiculoAlterado);
            this.Cilindradas = _motocicleta.Cilindradas;
            this.TemFreioDisco = _motocicleta.TemFreioDisco;
            this.TemPortaCapacete = _motocicleta.TemPortaCapacete;
            this.TemPartidaEletrica = _motocicleta.TemPartidaEletrica;
        }
    }
}
