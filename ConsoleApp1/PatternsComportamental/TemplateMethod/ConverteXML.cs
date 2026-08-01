using DesignPatterns.PatternsComportamental.TemplateMethod.AbstractModel;
using DesignPatterns.PatternsComportamental.TemplateMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO; 

namespace DesignPatterns.PatternsComportamental.TemplateMethod;

public class ConverteXML : ProcessaDados
{
    public ConverteXML(string xml) : base(xml: xml) 
    {
        
    }

    public override void ProcessarXML()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Pessoa>));
        var stringReader = new StringReader(this.xml);

        using (var reader = XmlReader.Create(stringReader)) 
        {
            this.pessoas = (List<Pessoa>)serializer.Deserialize(reader);
        }
        Console.WriteLine("Dados convertidos XML:");
        this.ApresentarDados();
    }
}
