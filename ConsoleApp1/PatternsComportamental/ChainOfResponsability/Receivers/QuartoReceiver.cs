using DesignPatterns.PatternsComportamental.ChainOfResponsability.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.ChainOfResponsability.Receivers;

public class QuartoReceiver : CobrancaReceiver
{
    public override Checkout ExecutarCobrancaSevice(Checkout checkout)
    {
        Console.WriteLine($"Realizando cobrança por taxa de Roupas de Quarto 15%");
        checkout.ValorTotal += (checkout.ValorTotal * 0.15); // Adiciona 15% de taxa roupas de quarto ao valor total
        Console.WriteLine($"Valor total com taxa roupas de quarto: {checkout.ValorTotal}");
        return base.ExecutarCobrancaSevice(checkout);
    }
}
