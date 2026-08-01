using DesignPatterns.PatternsComportamental.Visitor.Interfaces;
using DesignPatterns.PatternsComportamental.Visitor.Produtos;
using DesignPatterns.PatternsComportamental.Visitor.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Visitor;

public class Fiscal
{
    public void CalcularImpostos()
    {
        CalcularProdutosNaoPereciveis();
        CalcularProdutosPereciveis();
    }

    private static void CalcularProdutosNaoPereciveis()
    {
        List<ProdutoNaoPerecivel> produtoNaoPereciveis = new List<ProdutoNaoPerecivel>() { 
            new ProdutoNaoPerecivel("Antena wi-fi", 500),
            new ProdutoNaoPerecivel("Perfume frances", 1000),
        };
        Console.WriteLine("Calculando imposto sobre produtos não perecíveis...");
        foreach(var pnp in produtoNaoPereciveis)
        {
            Console.WriteLine(new String('#', 50));
            Console.WriteLine($"Produto: {pnp.Nome}, Peso: {pnp.Peso}g");
            foreach (var visitor in GetVisitors())
            {
                Console.WriteLine($"Imposto: {pnp.GetImposto(visitor).ToString("C")}");
            }
        }
    }

    private static void CalcularProdutosPereciveis()
    {
        List<ProdutoPerecivel> produtoPereciveis = new List<ProdutoPerecivel>() {
            new ProdutoPerecivel("Maçã", 100),
            new ProdutoPerecivel("Leite", 200),
        };
        Console.WriteLine("Calculando imposto sobre produtos perecíveis...");
        foreach (var pp in produtoPereciveis)
        {
            Console.WriteLine(new String('#', 50));
            Console.WriteLine($"Produto: {pp.Nome}, Peso: {pp.Peso}g");
            foreach (var visitor in GetVisitors())
            {
                Console.WriteLine($"Imposto: {pp.GetImposto(visitor).ToString("C")}");
            }
        }
    }

    private static List<IVisitor> GetVisitors() => new List<IVisitor>()
    {
        new RioDeJaneiroVisitor(), new SaoPauloVisitor()
    };



}
