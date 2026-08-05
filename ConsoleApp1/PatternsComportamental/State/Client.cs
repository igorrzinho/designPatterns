using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.State;

public class Client
{
    public void ExecutarContext()
    {
        Context context = new Context(new Estados.EstadoA());
        context.Trocar();
        context.Trocar();
        context.Trocar();
    }
}
