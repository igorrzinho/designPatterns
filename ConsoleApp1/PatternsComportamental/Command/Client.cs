using DesignPatterns.PatternsComportamental.Command.Receivers;
using DesignPatterns.PatternsComportamental.Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Command;

public class Client
{
    public void FalarComandos()
    {
        var luminaria = new LuzLuminiriaReceiver();
        ControleInvoker controle = new ControleInvoker();

        controle.AddCommand("ligar", new LigaLuminariaCommand(luminaria));
        controle.AddCommand("desligar", new DesligaLuminariaCommand(luminaria));
        controle.AddCommand("aumentar", new AumentaIntensidadeCommand(luminaria));
        controle.AddCommand("diminuir", new DiminuirIntensidadeCommand(luminaria));

        controle.ExecuteCommand("ligar");
        controle.ExecuteCommand("aumentar");
        controle.ExecuteCommand("diminuir");
        controle.ExecuteCommand("diminuir");
        controle.ExecuteCommand("aumentar");
        controle.ExecuteCommand("desligar");


        controle.ExecuteCommand("aumentar");
        controle.ExecuteCommand("ligar");
        controle.ExecuteCommand("ligar");
        controle.ExecuteCommand("ligar");
        controle.ExecuteCommand("diminuir");
        controle.ExecuteCommand("diminuir");
        controle.ExecuteCommand("diminuir");
        controle.ExecuteCommand("diminuir");
        controle.ExecuteCommand("diminuir");
        controle.ExecuteCommand("aumentar");
        controle.ExecuteCommand("aumentar");
        controle.ExecuteCommand("aumentar");
        controle.ExecuteCommand("aumentar");
        controle.ExecuteCommand("aumentar");
        controle.ExecuteCommand("desligar");
        controle.ExecuteCommand("desligar");
        controle.ExecuteCommand("desligar");
        controle.ExecuteCommand("desligar");
        controle.ExecuteCommand("desligar");
    }
}
