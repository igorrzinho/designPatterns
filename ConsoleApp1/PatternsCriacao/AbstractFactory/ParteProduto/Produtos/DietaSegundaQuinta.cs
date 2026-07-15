using DesignPatterns.PatternsCriacao.AbstractFactory.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class DietaSegundaQuinta : IDieta
    {
        public DietaSegundaQuinta()
        {
            this.ObterAlimentacao();
        }

        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta De Segunda e Quinta!");
        }
    }
}
