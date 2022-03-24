using ProntoSecorro.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntoSecorro
{
    public interface IGuincho
    {
         string Secorrer(Veiculo carro);
        public Porte.PorteTamanho TamananhoPorte { get; }
    }
}
