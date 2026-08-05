using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Memento;

public class Videocassete
{
    public void ExecutarAcaoVideo()
    {
        Originator originator = new Originator();
        originator.Estado = "Play";
        Caretaker caretaker = new Caretaker();
        caretaker.AddSnapshot(originator.CreateSnapshot());
        originator.Estado = "Pause";
        originator.RestoreSnapshot(caretaker.GetSnapshot());
        Console.WriteLine($"Estado atual do videocassete: {originator.Estado}");
    }
}
