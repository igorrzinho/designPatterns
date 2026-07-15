using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;
using DesignPatterns.PatternsCriacao.FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.FactoryMethod
{
    public abstract class ServicoFactory
    {
        public abstract IServico FabricarProduto(eTipoServicos tipoServicos);
    }
}
