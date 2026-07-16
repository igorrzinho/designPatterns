using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Adapter.Interfaces
{
    public interface IAdapter
    {
        public string ExecutarRotinaContasPagar(string mes);
        public string ExecutarRotinaContasReceber(string mes);
    }
}
