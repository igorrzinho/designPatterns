using DesignPatterns.PatternsCriacao.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.Builder
{
    public class Director
    {
        public void ConstruirStudio(StudioBuilder builder)
        {
            builder.EscolherPiso();
            builder.EscolherFinanciamento();
            builder.DefinirValorStudio();
        }


    }
}
