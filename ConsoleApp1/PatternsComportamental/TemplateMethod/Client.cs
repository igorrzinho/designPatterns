using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.TemplateMethod;

public class Client
{
    public void ConsumirEndpointXML()
    {
        Console.WriteLine("Consumindo endpoint XML...");
        var xml = ObtemDadosAPI.EndpointXML();
        ConverteXML converteXML = new ConverteXML(xml);
        converteXML.ProcessarXML();
    }

    public void ConsumirEndpointJSON()
    {
        Console.WriteLine("Consumindo endpoint JSON...");
        var json = ObtemDadosAPI.EndpointJSON();
        ConverteJson converteJson = new ConverteJson(json);
        converteJson.ProcessarJSON();
    }
}
