using DesignPatterns.PatternsComportamental.ChainOfResponsability.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.ChainOfResponsability.Receivers;

public class LavanderiaReceiver : CobrancaReceiver
{
    public override Checkout ExecutarCobrancaSevice(Checkout checkout)
    {
        Console.WriteLine($"Realizando cobrança por taxa de Lavanderia 10%");

        checkout.ValorTotal += (checkout.ValorTotal * 0.1); // Adiciona 10% de taxa de lavanderia ao valor total
        Console.WriteLine($"Valor total com taxa de lavanderia: {checkout.ValorTotal}");
        return base.ExecutarCobrancaSevice(checkout);
    }
}
