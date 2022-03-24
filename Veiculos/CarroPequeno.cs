using ProntoSecorro.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntoSecorro
{
    public class CarroPequeno : Veiculo
    {
        public CarroPequeno() : base()
        {
            TamananhoPorte = Porte.PorteTamanho.PEQUENO;
        }

    }
}

