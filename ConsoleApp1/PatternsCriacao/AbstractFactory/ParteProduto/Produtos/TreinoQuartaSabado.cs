using DesignPatterns.PatternsCriacao.AbstractFactory.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class TreinoQuartaSabado : ITreino
    {
        public TreinoQuartaSabado()
        {
            this.ObterTreino();
        }

        public void ObterTreino()
        {
            Console.WriteLine("Treino de Quarta e Sabado!");
        }
    }
}
