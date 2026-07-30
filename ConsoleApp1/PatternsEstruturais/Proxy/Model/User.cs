using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Proxy.Model;

public class User
{
    public  string Username{ get; private set; }
    public string Password{ get; private set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}
