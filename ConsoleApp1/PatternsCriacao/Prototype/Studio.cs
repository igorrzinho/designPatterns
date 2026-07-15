using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.Prototype
{
    public class Studio : StudioModel
    {
        private string _tipoStudio;
        private string _tipoFinanciamento;
        private decimal _valorStudio;

        public Studio(string tipoStudio, string tipoFinanciamento, decimal valorStudio)
        {
            _tipoStudio = tipoStudio;
            _tipoFinanciamento = tipoFinanciamento;
            _valorStudio = valorStudio;
        }

        public override StudioModel Clone()
        {
            Console.WriteLine(new String('=', 40));
            Console.WriteLine($"Clonando Studio: {_tipoStudio}");
            Console.WriteLine($"Tipo de Financiamento: {_tipoFinanciamento}");
            Console.WriteLine($"Valor do Studio: {_valorStudio.ToString("C")}");
            return this.MemberwiseClone() as StudioModel;
        }
    }
}
