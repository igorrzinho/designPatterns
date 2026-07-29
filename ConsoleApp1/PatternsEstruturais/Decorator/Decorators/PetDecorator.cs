using DesignPatterns.PatternsEstruturais.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Decorator.Decorators;

public abstract class PetDecorator : IPet
{
    protected IPet _pet;

    protected PetDecorator(IPet pet)
    {
        _pet = pet;
    }

    public virtual double GetValor()
    {
        return _pet.GetValor();
    }

    public virtual string GetTipo() 
    {
        return _pet.GetTipo();
    }

}