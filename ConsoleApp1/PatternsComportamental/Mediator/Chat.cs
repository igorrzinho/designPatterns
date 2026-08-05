using DesignPatterns.PatternsComportamental.Mediator.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Mediator;

public class Chat
{
    public void Conversar()
    {
        MediatorConcret mediator = new MediatorConcret();
        Atendente atendente = new Atendente(mediator);
        Paciente paciente = new Paciente(mediator);

        mediator.Atendente = atendente;
        mediator.Paciente = paciente;

        Console.WriteLine("Chat iniciado.");
        paciente.EnviarMensagem("Olá, preciso de ajuda com meu agendamento.");
        atendente.EnviarMensagem("Olá! Claro, posso ajudá-lo com isso. Qual é o seu nome?");
        paciente.EnviarMensagem("Meu nome é João.");
        atendente.EnviarMensagem("Obrigado, João. Qual é a data do seu agendamento?");
        paciente.EnviarMensagem("Meu agendamento é para o dia 15 de junho.");
        atendente.EnviarMensagem("Perfeito, João. Seu agendamento está confirmado para o dia 15 de junho. Posso ajudá-lo com mais alguma coisa?");
        paciente.EnviarMensagem("Não, obrigado. Isso é tudo.");
        Console.WriteLine(new String('-', 50));
    }
}
