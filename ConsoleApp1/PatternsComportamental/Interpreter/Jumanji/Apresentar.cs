using DesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using DesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFracos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Interpreter.Jumanji;

public class Apresentar
{
    public void ApresentarHabilidades()
    {
        List<IPontoForte> pontosFortes = new List<IPontoForte>
        {
            new Armeiro(),
            new Zoologia()
        };

        List<IPontoFraco> pontosFracos = new List<IPontoFraco>
        {
            new Bolo(),
            new Forca(),
            new Velocidade()
        };

        var mosseFinbar = new Contexto("Mosse Finbar");
        Habilidades habilidades = new Habilidades(pontosFortes, pontosFracos);
        habilidades.Interpretar(mosseFinbar);
    }
}
