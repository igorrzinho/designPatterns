using DesignPatterns.PatternsComportamental.Strategy.Interfaces;
using DesignPatterns.PatternsComportamental.Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Strategy.Service;

public class PremiumService : IService
{
    private Orcamento _orcamento;

    public PremiumService(Orcamento orcamento)
    {
        _orcamento = orcamento;
    }

    public void CalcularService()
    {
        Console.WriteLine(new String('#', 50));
        var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
        _orcamento.ValorTotal += porcentagem;
        if (_orcamento.CupomDesconto)
        {
            _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.02;
            Console.WriteLine($"Com cupom será descontado 2%, Valor total: {_orcamento.ValorTotal.ToString("C")}.");
        }

        Console.WriteLine($"Tipo de quarto: {_orcamento.Porcentagem}");
        Console.WriteLine($"Porcentagem serviço: {porcentagem.ToString()}");
        Console.WriteLine($"Quantidade de Dias: {_orcamento.Quantidade}");
        Console.WriteLine($"Valor diario: {_orcamento.ValorDiaria}");
        Console.WriteLine($"Valor total: {_orcamento.ValorTotal.ToString("C")}");
    }
}
