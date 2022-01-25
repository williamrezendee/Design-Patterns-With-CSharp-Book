using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class FabricaBaseZerg : IFabricaBases
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Zerg criada com sucesso!");
            EnergiaBaseZerg energia = new EnergiaBaseZerg();
            energia.Composicao();
            RevestimentoBaseZerg revestimento = new RevestimentoBaseZerg();
            revestimento.Composicao();
        }
    }
}
