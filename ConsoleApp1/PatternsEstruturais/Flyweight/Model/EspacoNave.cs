using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Flyweight.Model
{
    public abstract class EspacoNave
    {
        protected string nomeNave;
        protected string condicao;
        protected string acao;

        public string cor { get; set; }
        public string tamanho { get; set; }

        public abstract void Exibir(string cor, string tamanho);
       
    }
}
