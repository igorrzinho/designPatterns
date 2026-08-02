using DesignPatterns.PatternsComportamental.Command.Interfaces;
using DesignPatterns.PatternsComportamental.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Command.Commands;

public class LigaLuminariaCommand : ICommand
{
    private readonly LuzLuminiriaReceiver _luzLuminariaReceiver;

    public LigaLuminariaCommand(LuzLuminiriaReceiver luzLuminiriaReceiver)
    {
        _luzLuminariaReceiver = luzLuminiriaReceiver;
    }

    public void Execute()
    {
        _luzLuminariaReceiver.LigarLuz();
    }
}
