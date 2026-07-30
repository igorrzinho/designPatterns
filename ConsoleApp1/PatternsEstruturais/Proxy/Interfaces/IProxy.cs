using DesignPatterns.PatternsEstruturais.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Proxy.Interfaces;

public interface IProxy
{
    public void AcessarVPN(User user);
}
