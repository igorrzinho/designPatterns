using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Interpreter.Jumanji.MooseFinbar.PontosFortes;

public class Armeiro : IPontoForte
{
    public void Interpretar(Contexto contexto)
    {
        contexto.Conteudo += "[+] - Manuseio de Armas \n";
    }
}
