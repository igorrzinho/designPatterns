using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Memento;

public class Snapshot
{
    private string _estado;

    public Snapshot(string estado)
    {
        _estado = estado;
    }

    public string GetEstado()
    {
        return _estado;
    }
}
