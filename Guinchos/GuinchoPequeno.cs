using ProntoSecorro.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntoSecorro.Guinchos
{
    public class GuinchoPequeno : IGuincho
    {
        public Porte.PorteTamanho TamananhoPorte { get => Porte.PorteTamanho.PEQUENO;  }


        public string Secorrer(Veiculo carro)
        {
            string retorno = "";
            if (carro.TamananhoPorte == this.TamananhoPorte)
            {
                retorno += DateTime.Now + " ->" + "\n";
                retorno += "Secorrendo Carro " + carro.TamananhoPorte + " - Modelo " + carro.Modelo + "\n";
                retorno += "\n";
                retorno += "--------------------------------------------------------------";
            }
            return retorno;

        }

    }
}
