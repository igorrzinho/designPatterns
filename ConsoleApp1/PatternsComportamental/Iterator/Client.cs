using DesignPatterns.PatternsComportamental.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Iterator;

public class Client
{
    public void ConsumirEstruturaDados()
    {
        Aggregate aggregate = new Aggregate();
        aggregate[0] = "Item 1";
        aggregate[1] = "Item 2";
        aggregate[2] = "Item 3";
        aggregate[3] = "Item 4";
        aggregate[4] = "Item 5";
        aggregate[5] = "Item 6";

        IIterator iterator = aggregate.GetIterator();

        while (iterator.HasNext)
        {
            string item = iterator.Next;
            Console.WriteLine(item);
        }
    }
}
