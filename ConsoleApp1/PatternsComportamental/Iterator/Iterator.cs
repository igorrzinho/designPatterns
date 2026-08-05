using DesignPatterns.PatternsComportamental.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Iterator;

internal class Iterator : IIterator
{
    private IAggregate _aggregate;
    private int _position;

    public Iterator(IAggregate aggregate, int position = 0)
    {
        _aggregate = aggregate;
        _position = position;
    }

    public string Next
    {
        get
        {
            return _aggregate[_position++];
        }
    }

    public bool HasNext
    {
        get
        {
            return _position < _aggregate.Limit;
        }
    }
}
