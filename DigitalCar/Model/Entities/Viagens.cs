using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCar.Model.Entities
{
    public class Viagens
    {
        public int Id { get; set; }

        public string RuaPartida{ get; set; }
        public int NunPartida { get; set; }
        public string BairroPartida { get; set; }
        public string CidadePartida { get; set; }
        public string UfPartida { get; set; }
        public string CepPartida { get; set; }

        public string RuaDestino { get; set; }
        public int NunDestino { get; set; }
        public string BairroDestino { get; set; }
        public string CidadeDestino { get; set; }
        public string UfDestino { get; set; }
        public string CepDestino { get; set; }

        public int Km { get; set; }
        public int Combustivel { get; set; }
        public int Estacionamento { get; set; }
    }
}
