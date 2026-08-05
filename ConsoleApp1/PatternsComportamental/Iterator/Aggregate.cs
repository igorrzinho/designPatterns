using DesignPatterns.PatternsComportamental.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Iterator;

public class Aggregate : IAggregate
{
    private List<string> Collection = null;

    public Aggregate()
    {
        Collection = new List<string>();
    }

    public IIterator GetIterator()
    {
        return new Iterator(this);
    }

    public string this[int index]
    {
        get
        {
            if (index < Collection.Count)
            {
                return Collection[index];
            }
            return string.Empty;
        }
        set
        {
            Collection.Add(value);
        }
    }

    public int Limit {  get { return Collection.Count; } }


}
