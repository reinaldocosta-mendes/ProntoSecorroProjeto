using ProntoSecorro.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntoSecorro.factories
{
    public interface IGuinchoVeiculoFactory
    {
        public Veiculo createVeiculo();
        public IGuincho createGuincho();
    }
}
