using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Estacionamento.Modelos
{
    public class Automovel:Veiculo
    {
        private int ocupantes;
        private int volumePortaMalas;
        private int qtdePortas;

        public int Ocupantes { get => ocupantes; set => ocupantes = value; }
        public int VolumePortaMalas { get => volumePortaMalas; set => volumePortaMalas = value; }
        public int QtdePortas { get => qtdePortas; set => qtdePortas = value; }
    }
}
