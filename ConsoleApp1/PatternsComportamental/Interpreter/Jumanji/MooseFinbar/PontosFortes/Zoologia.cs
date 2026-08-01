using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes;

public class Zoologia : IPontoForte
{
    public void Interpretar(Contexto contexto)
    {
        contexto.Conteudo += "[+] - Conhecimento em Zoologia \n";
    }
}
