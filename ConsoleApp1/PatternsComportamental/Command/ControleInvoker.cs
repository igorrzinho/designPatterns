using DesignPatterns.PatternsComportamental.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Command;

public class ControleInvoker 
{
    private Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();
    
    public void AddCommand(string key, ICommand command)
    {
        _commands.Add(key, command);
    }

    public void ExecuteCommand(string key)
    {
        if (_commands.ContainsKey(key))
        {
            Console.WriteLine($"Executando comando '{key}'...");
            System.Threading.Thread.Sleep(2000); // Simula a execução do comando
            _commands[key].Execute();
        }
        else
        {
            Console.WriteLine($"Comando '{key}' não encontrado.");
        }
    }
}
