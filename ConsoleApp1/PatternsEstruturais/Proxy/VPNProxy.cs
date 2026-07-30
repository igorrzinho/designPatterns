using DesignPatterns.PatternsEstruturais.Proxy.Interfaces;
using DesignPatterns.PatternsEstruturais.Proxy.Model;
using DesignPatterns.PatternsEstruturais.Proxy.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Proxy;

public class VPNProxy : IProxy
{
    public void AcessarVPN(User user)
    {
        DataBaseConnection db = new DataBaseConnection();
        db.RegistrarAcessoVPN(user);
        Console.WriteLine(new String('-', 40));

        VPN vpn = new VPN();
        vpn.AcessarVPN(user);
    }
}
