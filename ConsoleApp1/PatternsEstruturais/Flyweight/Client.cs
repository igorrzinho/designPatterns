using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Flyweight
{
    public class Client
    {
        List<string> corTamanho = new List<string>()
        {
            "Azul:Pequena",
            "Cinza:Media",
            "Vermelha:Grande",
            "Azul:Media",
            "Cinza:Pequena",
            "Vermelha:Media"
        };

        public void ConsumirFlyweight()
        {
            FlyweightFactory factory = new FlyweightFactory();

            foreach (var item in corTamanho)
            {
                var cor = item.Split(":")[0];
                var tamanho = item.Split(":")[1];

                var espacoNave = factory.GetEspacoNave(cor);
                espacoNave.Exibir(cor, tamanho);
            }
        }
    }
}
