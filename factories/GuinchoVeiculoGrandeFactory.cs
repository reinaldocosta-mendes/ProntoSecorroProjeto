using ProntoSecorro.Guinchos;
using ProntoSecorro.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntoSecorro.factories
{
    public class GuinchoVeiculoGrandeFactory : IGuinchoVeiculoFactory
    {
        public IGuincho createGuincho()
        {
            return new GuinchoGrande();
        }

        public Veiculo createVeiculo()
        {
            return new CarroGrande();
        }
    }
}
