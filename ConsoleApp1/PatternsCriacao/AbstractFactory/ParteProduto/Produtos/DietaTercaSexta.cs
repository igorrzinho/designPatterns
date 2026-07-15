using DesignPatterns.PatternsCriacao.AbstractFactory.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class DietaTercaSexta : IDieta
    {
        public DietaTercaSexta() 
        {
            this.ObterAlimentacao();
        }

        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de terça e sexta!");
        }
    }
}
