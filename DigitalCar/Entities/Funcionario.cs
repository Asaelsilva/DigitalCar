using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCar.Entities
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int Cep { get; set; }
        public string UF { get; set; }
    }
}
