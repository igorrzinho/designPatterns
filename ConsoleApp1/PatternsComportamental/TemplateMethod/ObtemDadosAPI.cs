using DesignPatterns.PatternsComportamental.TemplateMethod.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns.PatternsComportamental.TemplateMethod;

public class ObtemDadosAPI
{
    public ObtemDadosAPI() { }

    public static string EndpointXML() 
    {
        List<Pessoa> pessoas = ObtemPessoas();
        XmlSerializer serializer = new XmlSerializer(typeof(List<Pessoa>));
        string xml = String.Empty;
        using (var sw = new StringWriter())
        {
            serializer.Serialize(sw, pessoas);
            xml = sw.ToString();
        }

        return xml;
    }

    public static string EndpointJSON()
    {
        List<Pessoa> pessoas = ObtemPessoas();
        string json = JsonConvert.SerializeObject(pessoas, Formatting.Indented);
        return json;
    }

    private static List<Pessoa> ObtemPessoas()
    {
        return new List<Pessoa>
        {
            new Pessoa()
            {   
                Nome = "João",
                CPF = "892.511.860-22", 
                Acoes = new List<Acoes>(){
                    new Acoes("AAA3", 50, 15.00),
                    new Acoes("BBB4", 100, 20.00)
                }
            },
            new Pessoa()
            { 
                Nome = "Maria",
                CPF = "903.773.720-05",
                Acoes = new List<Acoes>(){
                    new Acoes("CCC5", 200, 10.00),
                    new Acoes("DDD6", 150, 25.00)
                }
            },
            new Pessoa()
            { 
                Nome = "Pedro", 
                CPF = "330.464.210-28",
                Acoes = new List<Acoes>(){
                    new Acoes("EEE7", 75, 30.00),
                    new Acoes("FFF8", 50, 40.00)
                }
            }
        };
    }
}
