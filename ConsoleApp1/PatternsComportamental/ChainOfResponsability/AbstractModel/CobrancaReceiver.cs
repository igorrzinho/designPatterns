using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.ChainOfResponsability.AbstractModel;

public class CobrancaReceiver 
{
    public CobrancaReceiver Next = null;

    public CobrancaReceiver AddNext(CobrancaReceiver next)
    {
        this.Next = next;
        return next;
    }

    public virtual Checkout ExecutarCobrancaSevice(Checkout checkout)
    {
        if(Next != null)
            return Next.ExecutarCobrancaSevice(checkout);
        
        return checkout;
    }
}
