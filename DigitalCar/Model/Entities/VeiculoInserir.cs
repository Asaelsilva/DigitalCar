using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCar.Model.Entities
{
     public class VeiculoInserir
    {

        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Propriedade { get; set; }
        public string Status { get; set; }
        public string TpManutencao { get; set; }
        public string Cor { get; set; }
        public string Renavam { get; set; }
        public int Km { get; set; }
    }
}
