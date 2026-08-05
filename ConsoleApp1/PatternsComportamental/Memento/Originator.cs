using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Memento;

public class Originator
{
    private string _estado;
    public string Estado 
    { 
        get {
            return _estado;
        } set {
            _estado = value;
            Console.WriteLine("Capturando o estado: {0}", _estado);
        } 
    }

    public Snapshot CreateSnapshot()
    {
        return new Snapshot(_estado);
    }

    public void RestoreSnapshot(Snapshot snapshot)
    {
        _estado = snapshot.GetEstado();
        Console.WriteLine("Restaurando o estado: {0}", _estado);
    }

}
