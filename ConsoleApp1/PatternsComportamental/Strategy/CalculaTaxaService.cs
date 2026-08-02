using DesignPatterns.PatternsComportamental.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Strategy;

public class CalculaTaxaService
{
    public void CalcularTaxa(List<IService> services)
    {
        foreach (var service in services)
        {
            service.CalcularService();
        }
    }
}
