using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Memento;

public class Caretaker
{
    private Snapshot _estado;

    public void AddSnapshot(Snapshot snapshot)
    {
        _estado = snapshot;
    }

    public Snapshot GetSnapshot()
    {
        return _estado;
    }
}
