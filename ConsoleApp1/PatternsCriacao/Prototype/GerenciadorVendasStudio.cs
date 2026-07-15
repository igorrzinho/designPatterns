using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.Prototype
{
    public class GerenciadorVendasStudio
    {
        private Dictionary<string, StudioModel> studiosModel = new Dictionary<string, StudioModel>();

        public StudioModel this[string key]
        {
            get { return studiosModel[key]; }
            set { studiosModel[key] = value; }
        }
    }
}
