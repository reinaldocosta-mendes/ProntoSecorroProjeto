using ProntoSecorro.Guinchos;
using ProntoSecorro.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntoSecorro.factories
{
    public class GuinchoVeiculoMedioFactory : IGuinchoVeiculoFactory
    {
        public IGuincho createGuincho()
        {
            return new GuinchoMedio();
        }

        public Veiculo createVeiculo()
        {
            return new CarroMedio();
        }
    }
}
