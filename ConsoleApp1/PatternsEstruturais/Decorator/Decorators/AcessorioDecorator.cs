using DesignPatterns.PatternsEstruturais.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Decorator.Decorators;

public class AcessorioDecorator : PetDecorator
{
    public AcessorioDecorator(IPet pet) : base(pet)
    { }

    public override string GetTipo()
    {
        return base.GetTipo() + " com acessório";
    }

    public override double GetValor()
    {
        return base.GetValor() + 30.00;
    }
}
