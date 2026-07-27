using DesignPatterns.PatternsEstruturais.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Bridge.Abstracao.Interfaces;

public interface IMaterial
{
    public ICor CorImplementacao { get; set; }
    string ConsultarNoEstoque();
}
