using DesignPatterns.PatternsEstruturais.Flyweight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Flyweight.Fliweights
{
    public class Azul : EspacoNave
    {
        public Azul()
        {
            // Propriedades intrínsecas
            condicao = "Voando em linha reta";
            acao = "Atirando lasers";
        }
        public override void Exibir(string cor, string tamanho)
        {
            // Propriedades extrínsecas
            this.cor = cor;
            this.tamanho = tamanho;
            Console.WriteLine($"Nave tamnaho {this.tamanho} e cor {this.cor} {this.condicao} {this.acao}");
        }
    }
}
