using DesignPatterns.PatternsCriacao.AbstractFactory.ParteCriacao.Interfaces;
using DesignPatterns.PatternsCriacao.AbstractFactory.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.ParteCriacao.Factories
{
    public class TercaSextaFactory : IFactory
    {
        public TercaSextaFactory()
        {
            this.ObterRotinaDiaria();
        }

        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Terça e Sexta:");
            DietaTercaSexta dieta = new DietaTercaSexta();
            TreinoTercaSexta treino = new TreinoTercaSexta();
        } 
    }
}
