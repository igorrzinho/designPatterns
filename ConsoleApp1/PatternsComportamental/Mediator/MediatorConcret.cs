using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Mediator.AbstractModel;

public class MediatorConcret : Mediator
{
    private Atendente _atendente;
    private Paciente _paciente;

    public Atendente Atendente{ 
        set {  _atendente = value; }
    }

    public Paciente Paciente{ 
        set {  _paciente = value; }
    }

    public override void Send(string message, Contato contato)
    {
        if(contato == _paciente)
        {
            _atendente.ReceberMensagem(message);
        }
        else
        {
            _paciente.ReceberMensagem(message);
        }
    }
}
