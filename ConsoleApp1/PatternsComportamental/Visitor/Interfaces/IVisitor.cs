using DesignPatterns.PatternsComportamental.Visitor.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Visitor.Interfaces;

public interface IVisitor
{
    // Classes são os visitors que irão visitar os elementos do objeto e calcular o imposto
    double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel);
    double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel);
}
