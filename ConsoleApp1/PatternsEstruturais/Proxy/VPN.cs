using DesignPatterns.PatternsEstruturais.Proxy.Interfaces;
using DesignPatterns.PatternsEstruturais.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Proxy;

public class VPN : IProxy
{
    public void AcessarVPN(User user)
    {
        Console.WriteLine("[+] - Acessando VPN");
        Thread.Sleep(2000);
        Console.WriteLine($"{user.Username} - Conectado à VPN");
    }
}
