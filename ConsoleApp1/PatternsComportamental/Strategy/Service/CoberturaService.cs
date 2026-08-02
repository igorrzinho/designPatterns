using DesignPatterns.PatternsComportamental.Strategy.Interfaces;
using DesignPatterns.PatternsComportamental.Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Strategy.Service;

public class CoberturaService : IService
{
    private Orcamento _orcamento;

    public CoberturaService(Orcamento orcamento)
    {
        _orcamento = orcamento;
    }

    public void CalcularService()
    {
        Console.WriteLine(new String('#', 50));
        var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
        _orcamento.ValorTotal += porcentagem;

        Console.WriteLine($"O Valor total foi {_orcamento.ValorTotal.ToString("C")}.");
        if(_orcamento.Quantidade > 60)
        {
            _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.03;
            Console.WriteLine($"Por ficar mais de 60 dias, será descontado 3%, Valor total: {_orcamento.ValorTotal.ToString("C")}.");
        }
        Console.WriteLine($"Tipo de quarto: {_orcamento.Porcentagem}");
        Console.WriteLine($"Porcentagem serviço: {porcentagem.ToString()}");
        Console.WriteLine($"Quantidade de Dias: {_orcamento.Quantidade}");
        Console.WriteLine($"Valor diario: {_orcamento.ValorDiaria}");
        Console.WriteLine($"Valor total: {_orcamento.ValorTotal.ToString("C")}");
    }
}
