using DesignPatterns.PatternsComportamental.Interpreter.Jumanji.Interfaces;
using DesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using DesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Interpreter.Jumanji;

public class Habilidades : IExpressao
{
    private List<IPontoForte> _pontosFortes;
    private List<IPontoFraco> _pontosFracos;

    public Habilidades(List<IPontoForte> pontosFortes, List<IPontoFraco> pontosFracos)
    {
        _pontosFortes = pontosFortes;
        _pontosFracos = pontosFracos;
    }

    public void Interpretar(Contexto contexto)
    {
        Console.WriteLine($"Personagem: {contexto.Personagem}");
        contexto.Conteudo += "Exibindo Habilidades... \n\n Pontos Fortes: \n";
        
        foreach (var pontoForte in _pontosFortes)
        {
            pontoForte.Interpretar(contexto);
        }

        contexto.Conteudo += "\n Pontos Fracos: \n";

        foreach (var pontoFraco in _pontosFracos)
        {
            pontoFraco.Interpretar(contexto);
        }

        Console.WriteLine(contexto.Conteudo);
    }
}
