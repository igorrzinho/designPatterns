using DesignPatterns.PatternsEstruturais.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Bridge.Implementacao;

public class Azul : ICor
{
    public string ConsultarQuantidadePorCor(string tipoAbstracao)
    {
        // Implementa a Complexidade de consultar no banco a quantidade por cor
        var random = new Random();
        var quantidade = random.Next(1, 100);
        return $"Existem {quantidade} para o {tipoAbstracao} de cor Azul no estoque";
    }
}
