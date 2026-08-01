using DesignPatterns.PatternsComportamental.Observer.Interfaces;
using DesignPatterns.PatternsComportamental.Observer.Model;
using DesignPatterns.PatternsComportamental.Observer.Observers;
using DesignPatterns.PatternsComportamental.Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Observer;

public class SendMail
{
    public void EnviarEmail()
    {
        string msgNaoAssinante = $"Olá, você não é assinante do nosso serviço. \nAssine agora e aproveite todos os benefícios do mês {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)}!";
        string msgAssinante = $"Olá, você é assinante do nosso serviço. Obrigado por ser um de nós!\n Acompanhe nossos lançamentos para o mês de {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)}!";

        List<IObservavel> observaveis = new List<IObservavel>
        {
            new NaoAssinante(new Pessoa(1, "Jóse", "jose@email.com"), msgNaoAssinante),
            new NaoAssinante(new Pessoa(1, "Maria", "maria@email.com"), msgNaoAssinante),
            new Assinante(new Pessoa(1, "João", "joao@email.com"), msgAssinante),
            new Assinante(new Pessoa(1, "Carla", "carla@email.com"), msgAssinante)
        };

        PrimeVideos primeVideos = new PrimeVideos();
        foreach (var observavel in observaveis)
        {
            primeVideos.AddObservavel(observavel);
        }

        primeVideos.NotificarObservavel();
    }
}
