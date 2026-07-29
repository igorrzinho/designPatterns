using DesignPatterns.PatternsEstruturais.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Decorator.Decorators;

public class LuxoSpaDecorator : PetDecorator
{
    public LuxoSpaDecorator(IPet pet) : base(pet)
    {
    }

    public override double GetValor()
    {
        return base.GetValor() + 200.00;
    }

    public override string GetTipo()
    {
        return base.GetTipo() + " com luxo e spa";
    }
}
