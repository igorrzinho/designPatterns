using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Command.Receivers;

public class LuzLuminiriaReceiver
{
    private bool _ligada = false;
    private int _intensidade = 100;

    public string GetEstadoLuminaria() => _ligada ? "Ligada" : "Desligada";

    public void LigarLuz()
    {
        if(_ligada)
            Console.WriteLine("Luminária já está ligada.");
        
        _ligada = true;
        Console.WriteLine("Luminária ligada.");
    }

    public void DesligarLuz()
    {
        if(!_ligada)
            Console.WriteLine("Luminária já está desligada.");
       
        _ligada = false;
        Console.WriteLine("Luminária desligada.");
    }

    public void AumentarIntensidade()
    {
        if (_ligada && _intensidade < 100 && _intensidade >= 0)
        {
            _intensidade += 20;
            Console.WriteLine($"Intensidade aumentada para {_intensidade}%.");
        }
        else
        {
            Console.WriteLine("Não é possível aumentar a intensidade.");
        }
    }

    public void DiminuirIntensidade()
    {
        if (_ligada && _intensidade > 0 && _intensidade <= 100)
        {
            _intensidade -= 20;
            Console.WriteLine($"Intensidade diminuída para {_intensidade}%.");
        }
        else
        {
            Console.WriteLine("Não é possível diminuir a intensidade.");
        }
    }

}
