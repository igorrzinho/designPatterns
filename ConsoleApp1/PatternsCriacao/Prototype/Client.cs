using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.Prototype
{
    public class Client
    {
        public void ConsumirStudio()
        {
            GerenciadorVendasStudio gerenciador = new GerenciadorVendasStudio();
            gerenciador["24m"] = new Studio("24m", "Sicred", 100000.00M);
            gerenciador["26m"] = new Studio("26m", "Crefisa", 120000.00M);
            gerenciador["28m"] = new Studio("28m", "Caixa", 150000.00M);

            StudioModel firstClone01 = gerenciador["24m"].Clone();
            StudioModel secondClone01 = gerenciador["26m"].Clone();
            StudioModel thirdClone01 = gerenciador["28m"].Clone();

            StudioModel firstClone02 = gerenciador["24m"].Clone();
            StudioModel secondClone02 = gerenciador["26m"].Clone();
            StudioModel thirdClone02 = gerenciador["28m"].Clone();
        }
    }
}
