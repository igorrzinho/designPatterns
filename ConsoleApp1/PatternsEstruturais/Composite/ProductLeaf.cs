using DesignPatterns.PatternsEstruturais.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Composite;

public class ProductLeaf : ComponentModel
{
    private string _nome;
    private double _valor;

    public ProductLeaf(string nome, double valor)
    {
        _nome = nome;
        _valor = valor;
    }

    public override void Add(params ComponentModel[] components)
    {
        Console.WriteLine("Não é possivel adicionar objetos em uma classe do tipo Leaf");
    }

    public override ComponentModel GetChild(int index)
    {
        Console.WriteLine("Não é possivel obter filhos de uma classe do tipo Leaf");
        return null;
    }

    public override double Operation()
    {
        Console.WriteLine($"Produto: {_nome}, Valor: {_valor.ToString("C")}");
        Console.WriteLine(new String('-', 30));
        return _valor;
    }

    public override void Remove(ComponentModel components)
    {
        Console.WriteLine("Não é possivel remover items de uma classe do tipo Leaf");
    }
}
