using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.FactoryMethod.Servicos
{
    public class PremiumServico : IServico
    {
        public PremiumServico()
        {
            Console.WriteLine("Produto Premium Criado!");
        }
        public void ExecultaCobrancaServico()
        {
            // Logica de cobranca de servicos para Premium
        }
    }
}
