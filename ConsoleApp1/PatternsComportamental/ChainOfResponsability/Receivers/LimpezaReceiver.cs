using DesignPatterns.PatternsComportamental.ChainOfResponsability.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.ChainOfResponsability.Receivers;

public class LimpezaReceiver : CobrancaReceiver
{
    public override Checkout ExecutarCobrancaSevice(Checkout checkout)
    {
        Console.WriteLine($"Realizando cobrança por taxa de Limpeza 5%");
        checkout.ValorTotal += (checkout.ValorTotal * 0.05); // Adiciona 5% de taxa de limpeza ao valor total
        Console.WriteLine($"Valor total com taxa de limpeza: {checkout.ValorTotal}");
        return base.ExecutarCobrancaSevice(checkout);
    }
}
