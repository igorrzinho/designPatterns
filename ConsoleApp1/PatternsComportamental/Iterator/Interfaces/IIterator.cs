using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Iterator.Interfaces;

public interface IIterator
{
    string Next {  get; }
    bool HasNext { get; }
}
