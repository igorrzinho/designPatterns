using DesignPatterns.PatternsCriacao.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.Builder.Builders
{
    public class Studio28mBuilder : StudioBuilder
    {
        public Studio28mBuilder()
        {
            studio = new Studio28m();
        }

        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(180000.00m);
        }

        public override void EscolherFinanciamento()
        {
            studio.EscolherFinanciamento("Sicred");
        }

        public override void EscolherPiso()
        {
            studio.EscolherPiso("Cimento");
        }
    }
}
