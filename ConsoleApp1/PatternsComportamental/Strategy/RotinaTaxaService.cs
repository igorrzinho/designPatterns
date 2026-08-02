using DesignPatterns.PatternsComportamental.Strategy.Model;
using DesignPatterns.PatternsComportamental.Strategy.Interfaces;
using DesignPatterns.PatternsComportamental.Strategy.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.PatternsComportamental.Strategy.Service;

namespace DesignPatterns.PatternsComportamental.Strategy;

public class RotinaTaxaService
{
    public void ExecutarRotina()
    {
        var cobertura01 = new Orcamento(1, 70, 30, PorcentagemService.Cobertura);
        var cobertura02 = new Orcamento(2, 70, 65, PorcentagemService.Cobertura);
        var cobertura03 = new Orcamento(3, 70, 50, PorcentagemService.Cobertura, true);
        var master01 = new Orcamento(4, 50, 30, PorcentagemService.Cobertura);
        var master02 = new Orcamento(5, 50, 65, PorcentagemService.Cobertura);
        var master03 = new Orcamento(6, 50, 68, PorcentagemService.Cobertura, true);
        var premium01 = new Orcamento(7, 40, 30, PorcentagemService.Cobertura);
        var premium02 = new Orcamento(8, 40, 65, PorcentagemService.Cobertura);
        var premium03 = new Orcamento(9, 40, 68, PorcentagemService.Cobertura, true);
        var tradicional01 = new Orcamento(10, 30, 30, PorcentagemService.Cobertura);
        var tradicional02 = new Orcamento(11, 30, 65, PorcentagemService.Cobertura);
        var tradicional03 = new Orcamento(12, 30, 50, PorcentagemService.Cobertura, true);

        var orcamentos = new List<IService>
        {
            new CoberturaService(cobertura01),
            new CoberturaService(cobertura02),
            new CoberturaService(cobertura03),
            new MasterService(master01),
            new MasterService(master02),
            new MasterService(master03),
            new PremiumService(premium01),
            new PremiumService(premium02),
            new PremiumService(premium03),
            new TradicionalService(tradicional01),
            new TradicionalService(tradicional02),
            new TradicionalService(tradicional03)
        };

        CalculaTaxaService calculaTaxa = new CalculaTaxaService();
        calculaTaxa.CalcularTaxa(orcamentos);
    }
}
