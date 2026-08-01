using DesignPatterns.PatternsComportamental.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Visitor.Produtos;

public class ProdutoPerecivel : IProduct
{
    public ProdutoPerecivel(string nome, double peso)
    {
        Nome = nome;
        Peso = peso;
    }

    public string Nome { get; set; }
    public double Peso { get; set; }

    public double GetImposto(IVisitor visitor)
    {
        return visitor.CalcularImpostoProdutoPerecivel(this);
    }
}
