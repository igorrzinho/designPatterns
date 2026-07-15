using DesignPatterns.PatternsCriacao.AbstractFactory.ParteCriacao.Factories;
using DesignPatterns.PatternsCriacao.AbstractFactory.ParteCriacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.AbstractFactory
{
    public class Client
    {
        public void ConsultarRotinaAluno()
        {
            var continuar = true;

            while (continuar)
            {
                IFactory factory = null;
                Console.WriteLine("Selecione a rotina desejada: ");
                Console.WriteLine("1 - Segunta e Quinta");
                Console.WriteLine("2 - Terça e Sexta");
                Console.WriteLine("3 - Quarta e Sabado");
                Console.WriteLine("Selecione a rotina: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        factory = new SegundaQuintaFactory();
                        break;
                    case "2":
                        factory = new TercaSextaFactory();
                        break;
                    case "3":
                        factory = new QuartaSabadoFactory();
                        break;
                    default:
                        Console.WriteLine("Digite um numero valido");
                        break;
                }
                Console.WriteLine("Deseja ver outra rotina?(1-Sim ou 2-Não)");

                var resp = Console.ReadLine();
                continuar = resp == "1";
            }
        }
    }
}
