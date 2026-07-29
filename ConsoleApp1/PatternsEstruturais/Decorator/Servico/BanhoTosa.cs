using DesignPatterns.PatternsEstruturais.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Decorator.Servico;

public class BanhoTosa : IPet
{
    private string _tipo;
    private double _valor;

    public BanhoTosa(string tipo, double valor)
    {
        _tipo = tipo;
        _valor = valor;
    }

    public string GetTipo()
    {
        return _tipo;
    }

    public double GetValor()
    {
        return _valor;
    }
}
