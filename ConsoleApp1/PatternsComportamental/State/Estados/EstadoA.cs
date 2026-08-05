using DesignPatterns.PatternsComportamental.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.State.Estados;

public class EstadoA : IEstado
{
    public void Acoes(Context context)
    {
        Console.WriteLine("Ações do Estado A");
        context.Estado = new EstadoB();
    }
}
