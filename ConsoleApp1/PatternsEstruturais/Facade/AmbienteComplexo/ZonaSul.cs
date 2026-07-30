using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Facade.AmbienteComplexo;

public class ZonaSul
{
    public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
    {
        // Executa store procedure para itens vendas perdidas e regras de negocio região sul
        Console.WriteLine("Execultando complexidade rotina de vendas perdidas região Sul");
        return new List<object>();
    }

}
