using DesignPatterns.PatternsEstruturais.Flyweight.Fliweights;
using DesignPatterns.PatternsEstruturais.Flyweight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, EspacoNave> nave_lista = new Dictionary<string, EspacoNave>();


        public EspacoNave GetEspacoNave(string cor)
        {
            EspacoNave nave = null;

            if (nave_lista.ContainsKey(cor))
            {
                nave = nave_lista[cor];
            }
            else
            {
                switch (cor)
                {
                    case "Azul":
                        nave = new Azul();
                        break;
                    case "Cinza":
                        nave = new Cinza();
                        break;
                    case "Vermelha":
                        nave = new Vermelha();
                        break;
                    default:
                        break;
                }
                nave_lista.Add(cor, nave);
            }

            return nave;
        }
    }
}
