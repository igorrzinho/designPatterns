using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Iterator.Interfaces;

public interface IAggregate
{
    IIterator GetIterator();
    string this[int index] { get; set; }
    public int Limit { get; } 
}
