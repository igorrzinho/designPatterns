using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.PatternsCriacao.FactoryMethod.Enums;

namespace DesignPatterns.PatternsCriacao.FactoryMethod
{
    public class Client
    {
        public void ExecultarCriacaoProduto()
        {
            var slc = new SelecionaServico();
            var continuar = true;
            while (continuar)
            {
                Console.WriteLine("Selecione o tipo de serviço:\n");
                Console.WriteLine("0 - Tradicional");
                Console.WriteLine("1 - Master");
                Console.WriteLine("2 - Premium");
                Console.WriteLine("3 - Cobetura");
                Console.WriteLine("Digite o numero do serviço que deseja cobrar: ");
                int tipoServico = Convert.ToInt32(Console.ReadLine());

                var servicoProduto = slc.FabricarProduto((eTipoServicos)tipoServico);

                Console.WriteLine("Deseja calcular outro servico? (1-Sim ou 2-Não)");
                int resp = Convert.ToInt32(Console.ReadLine());
                continuar = resp == 1;
            }
        }
    }
}