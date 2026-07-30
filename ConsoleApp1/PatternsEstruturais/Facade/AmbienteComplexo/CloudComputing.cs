using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Facade.AmbienteComplexo;

public class CloudComputing
{
    public void GerarRelatorioPerdasGanhos(List<object> sul, List<object> norte)
    {
        // Executa cruzamento de dados dos itens vendios salvos na nuvem com dados das lojas das regiões Sul e Norte
        Console.WriteLine("Gereção e apresentação do consolidade mensal de perdas e ganhos");
    }
}
