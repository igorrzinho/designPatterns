using DesignPatterns.PatternsEstruturais.Bridge.Abstracao.Interfaces;
using DesignPatterns.PatternsEstruturais.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Bridge.Abstracao;

public class PincelMarcador : IMaterial
{
    public ICor CorImplementacao { get; set; }

    public string ConsultarNoEstoque()
    {
        return this.CorImplementacao.ConsultarQuantidadePorCor("PincelMarcador");
    }
}
