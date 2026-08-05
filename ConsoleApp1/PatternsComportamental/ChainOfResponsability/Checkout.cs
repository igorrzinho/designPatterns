using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.ChainOfResponsability;

public class Checkout
{
    public Checkout(int clientId, int quantidadeDias, double valorDiaria)
    {
        ClientId = clientId;
        QuantidadeDias = quantidadeDias;
        ValorDiaria = valorDiaria;
        CalcularTotal();
    }

    public int ClientId { get; set; }
    public int QuantidadeDias { get; set; }
    public double ValorDiaria { get; set; }
    public double ValorTotal { get; set; }

    private void CalcularTotal()
    {
        this.ValorTotal = this.QuantidadeDias * this.ValorDiaria;
    }
}
