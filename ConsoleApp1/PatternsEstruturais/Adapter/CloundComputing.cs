using DesignPatterns.PatternsEstruturais.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Adapter
{
    public class CloundComputing
    {
        IAdapter adapter;

        public CloundComputing()
        {
            this.adapter = new Adapter(new BusinessLegado());
        }

        public void ProcessarContas(string mes)
        {
            var result = this.adapter.ExecutarRotinaContasPagar(mes);
            Console.WriteLine("Processando camada Cloud Computing Conta a pagar");
            Thread.Sleep(3000);
            Console.WriteLine(result);

            Console.WriteLine(new String('=', 50));

            result = this.adapter.ExecutarRotinaContasReceber(mes);
            Console.WriteLine("Processando camada Cloud Computing Conta a receber");
            Thread.Sleep(3000);
            Console.WriteLine(result);

            Console.WriteLine("Processo Finalizado");
        }
    }
}
