using DesignPatterns.PatternsEstruturais.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Proxy.SQL;

public class DataBaseConnection
{
    public void RegistrarAcessoVPN(User user)
    {
        var query = $"INSERT INTO tb_acessos_vpn (Username, Password, DataHora) VALUES ('{user.Username}', '{user.Password}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')";
        Console.WriteLine("[!] - Registrando acesso à VPN no banco de dados");
        Console.WriteLine(query);
    }
}
