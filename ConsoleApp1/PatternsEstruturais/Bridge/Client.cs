using DesignPatterns.PatternsEstruturais.Bridge.Abstracao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Bridge;

public class Client 
{
    public IMaterial Material { get; set; } 
    public void ConsultarNoEstoque()
    {
        Console.WriteLine(this.Material.ConsultarNoEstoque());
    }
}
