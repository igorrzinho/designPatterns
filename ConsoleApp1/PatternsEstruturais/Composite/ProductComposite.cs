using DesignPatterns.PatternsEstruturais.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Composite;

public class ProductComposite : ComponentModel
{
    private List<ComponentModel> _components = new();
    
    public ProductComposite(List<ComponentModel> components)
    {
        _components = components;
    }
    public ProductComposite()
    {

    }

    public override double Operation()
    {
        double total = 0;
        for (int i = 0; i < _components.Count; i++)
        {
            var component = _components[i];
            var child = component.GetChild(i);
            total += component.Operation();
        }
        return total;
    }

    public override void Add(params ComponentModel[] components)
    {
        _components.AddRange(components);
    }

    public override void Remove(ComponentModel components)
    {
        _components.Remove(components);
    }

    public override ComponentModel GetChild(int index)
    {
        if(_components.Count == 0)
        {
            Console.WriteLine("Não possui componentes.");
            return null;
        }
        var component = _components[index];
        return component;
    }
}
