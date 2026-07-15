using DesignPatterns.PatternsCriacao.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.Builder.Builders
{
    public class Studio24mBuilder : StudioBuilder
    { 
        public Studio24mBuilder()
        {
            studio = new Studio24m();
        }
        public override void DefinirValorStudio()
        {
            studio.DefinirValorStudio(150000.00m);
        }

        public override void EscolherFinanciamento()
        {
            studio.EscolherFinanciamento("Financiamento Bancário Caixa");
        }

        public override void EscolherPiso()
        {
            studio.EscolherPiso("Porcelanato Preto");
        }
    }
}
