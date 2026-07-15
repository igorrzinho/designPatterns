using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.FactoryMethod.Servicos
{
    public class TradicionalServico : IServico
    {
        public TradicionalServico()
        {
            Console.WriteLine("Produto Tradicional Criado!");
        }
        public void ExecultaCobrancaServico()
        {
            // Logica de cobranca de servicos para Tradicional
        }
    }
}
