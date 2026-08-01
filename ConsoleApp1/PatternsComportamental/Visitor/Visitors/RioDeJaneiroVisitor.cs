using DesignPatterns.PatternsComportamental.Visitor.Interfaces;
using DesignPatterns.PatternsComportamental.Visitor.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Visitor.Visitors;

public class RioDeJaneiroVisitor : IVisitor
{
    public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
    {
        Console.Write(new String('-', 20));
        Console.Write("Rio De Janeiro");
        Console.Write(new String('-', 20));
        var imposto = (produtoNaoPerecivel.Peso / 100) + 5;
        Console.WriteLine($"\nImposto para {produtoNaoPerecivel.Nome}");
        return imposto;
    }

    public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
    {
        Console.Write(new String('-', 20));
        Console.Write("Rio de Janeiro");
        Console.Write(new String('-', 20));
        var imposto = (produtoPerecivel.Peso / 100) + 10;
        Console.WriteLine($"\nImposto para {produtoPerecivel.Nome}");
        return imposto;
    }
}
