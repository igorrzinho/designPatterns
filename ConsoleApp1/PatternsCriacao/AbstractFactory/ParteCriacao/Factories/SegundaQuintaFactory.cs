using DesignPatterns.PatternsCriacao.AbstractFactory.ParteCriacao.Interfaces;
using DesignPatterns.PatternsCriacao.AbstractFactory.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.ParteCriacao.Factories
{
    public class SegundaQuintaFactory : IFactory
    {
        public SegundaQuintaFactory()
        {
            this.ObterRotinaDiaria();
        }

        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Segunta e quinta");
            DietaSegundaQuinta dieta = new DietaSegundaQuinta();
            TreinoSegundaQuinta treino = new TreinoSegundaQuinta();
        }
    }
}
