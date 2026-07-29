using DesignPatterns.PatternsEstruturais.Decorator.Decorators;
using DesignPatterns.PatternsEstruturais.Decorator.Interfaces;
using DesignPatterns.PatternsEstruturais.Decorator.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Decorator;

public class Client
{
    public void ConsumirServico()
    {
        Console.WriteLine("Decorator Pattern - Exemplo de uso");
        IPet banhoTosa = new BanhoTosa("Banho e Tosa", 50.0);

        IPet acessorio = new AcessorioDecorator(banhoTosa);

        IPet luxo = new LuxoSpaDecorator(acessorio);
        Console.WriteLine("Resumo dos serviços:");

        Console.WriteLine($"Serviço: {luxo.GetTipo()} - Valor: {luxo.GetValor()}");
    }
}
