using DesignPatterns.PatternsEstruturais.Proxy.Interfaces;
using DesignPatterns.PatternsEstruturais.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Proxy;

public class Client
{
    public void ConectarVPN()
    {
        VPNProxy vpnProxy = new VPNProxy();
        Console.WriteLine("Digite o Username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Digite a senha: ");
        string password = Console.ReadLine();

        User user = new User(username, password);
        vpnProxy.AcessarVPN(user);
    }
}
