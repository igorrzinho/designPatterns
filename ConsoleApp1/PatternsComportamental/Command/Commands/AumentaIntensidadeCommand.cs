using DesignPatterns.PatternsComportamental.Command.Interfaces;
using DesignPatterns.PatternsComportamental.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Command.Commands;

public class AumentaIntensidadeCommand : ICommand
{
    private readonly LuzLuminiriaReceiver _luzLuminariaReceiver;

    public AumentaIntensidadeCommand(LuzLuminiriaReceiver luzLuminiriaReceiver)
    {
        _luzLuminariaReceiver = luzLuminiriaReceiver;
    }

    public void Execute()
    {
        _luzLuminariaReceiver.AumentarIntensidade();
    }
}
