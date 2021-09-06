using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Estacionamento.Modelos
{
    class Motocicleta:Veiculo
    {
        private int cilindradas;
        private bool temFreioDisco;
        private bool temPortaCapacete;
        private bool temPartidaEletrica;

        public int Cilindradas { get => cilindradas; set => cilindradas = value; }
        public bool TemFreioDisco { get => temFreioDisco; set => temFreioDisco = value; }
        public bool TemPortaCapacete { get => temPortaCapacete; set => temPortaCapacete = value; }
        public bool TemPartidaEletrica { get => temPartidaEletrica; set => temPartidaEletrica = value; }
    }
}
