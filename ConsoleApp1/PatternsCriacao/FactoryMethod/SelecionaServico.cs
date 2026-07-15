using DesignPatterns.PatternsCriacao.FactoryMethod.Enums;
using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;
using DesignPatterns.PatternsCriacao.FactoryMethod.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.FactoryMethod
{
    public class SelecionaServico : ServicoFactory
    {
        public override IServico FabricarProduto(eTipoServicos tipoServicos)
        {
            switch (tipoServicos)
            {
                case eTipoServicos.tradicional:
                    return new TradicionalServico();
                case eTipoServicos.premium:
                    return new PremiumServico();
                case eTipoServicos.master:
                    return new MasterServico();
                case eTipoServicos.cobeturta:
                    return new CoberturaServico();
                default:
                    return null;
            }
        }
    }
}
