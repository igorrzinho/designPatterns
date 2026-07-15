using DesignPatterns.PatternsCriacao.AbstractFactory.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class TreinoTercaSexta : ITreino
    {
        public TreinoTercaSexta()
        {
            this.ObterTreino();
        }

        public void ObterTreino()
        {
            Console.WriteLine("Treino de Terça e Sexta!");
        }
    }
}
