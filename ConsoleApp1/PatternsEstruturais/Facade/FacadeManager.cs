using DesignPatterns.PatternsEstruturais.Facade.AmbienteComplexo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Facade;

public class FacadeManager
{
    public void ExecutarComplexidade()
    {
        ZonaNorte zonaNorte = new ZonaNorte();
        ZonaSul zonaSul = new ZonaSul();
        CloudComputing cloudComputing = new CloudComputing();

        var sul = zonaSul.ExecutaRotinaVendasPerdidas(DateTime.Now);
        var norte = zonaNorte.ExecutaRotinaVendasPerdidas(DateTime.Now);
        cloudComputing.GerarRelatorioPerdasGanhos(sul, norte);
    }
}
