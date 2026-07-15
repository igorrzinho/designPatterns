using DesignPatterns.PatternsCriacao.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.Builder.Builders
{
    public class Studio26mBuilder : StudioBuilder
    {
        public Studio26mBuilder()
        {
            studio = new Studio26m();
        }

        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(160000.00m);
        }

        public override void EscolherFinanciamento()
        {
            studio.EscolherFinanciamento("Minha casa minha vida");
        }
        
        public override void EscolherPiso()
        {
            studio.EscolherPiso("Ceramica Azul");
        }
    }
}
