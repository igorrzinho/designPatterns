using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Mediator.AbstractModel;

public abstract class Contato
{
    protected Mediator _mediator;

    protected Contato(Mediator mediator)
    {
        _mediator = mediator;
    }


}
