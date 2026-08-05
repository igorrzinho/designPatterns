using DesignPatterns.PatternsComportamental.ChainOfResponsability.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.ChainOfResponsability;

public class Sender
{
    public void RealizarCheckout()
    {
        Checkout checkout = new Checkout(clientId: 1, quantidadeDias: 3, valorDiaria: 80.0);
        Console.WriteLine($"Valor total: R$ {checkout.ValorTotal.ToString("C")}");
        var lavanderia = new LavanderiaReceiver();
        var quarto = new QuartoReceiver();
        var limpeza = new LimpezaReceiver();

        lavanderia.AddNext(quarto);
        quarto.AddNext(limpeza);

        lavanderia.ExecutarCobrancaSevice(checkout);

        Console.WriteLine("\nCheckout realizado com sucesso!");
        Console.WriteLine($"\nValor total: R$ {checkout.ValorTotal.ToString("C")}");
    }
}
