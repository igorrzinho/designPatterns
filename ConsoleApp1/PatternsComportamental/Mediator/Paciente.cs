using DesignPatterns.PatternsComportamental.Mediator.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Mediator;

public class Paciente : Contato
{
    public Paciente(AbstractModel.Mediator mediator) : base(mediator)
    {
    }

    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Paciente escrevendo");
        Thread.Sleep(2000);
        this._mediator.Send(mensagem, this);
        Thread.Sleep(2000);
    }

    public void ReceberMensagem(string mensagem)
    {
        Console.WriteLine($"Para Paciente: {mensagem}");
        Thread.Sleep(2000);
    }
}

