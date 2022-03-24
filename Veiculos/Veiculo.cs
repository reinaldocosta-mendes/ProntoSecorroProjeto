using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntoSecorro.Veiculos
{
  public  class Veiculo
    {

        public string Modelo { get; set; }
        public Porte.PorteTamanho TamananhoPorte { get; set; }
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
     public Veiculo()
        {

        }

    }
}
