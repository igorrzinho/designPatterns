using DesignPatterns.PatternsComportamental.TemplateMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.TemplateMethod.AbstractModel;

public class ProcessaDados
{
    protected List<Pessoa> pessoas { get; set; }
    protected string json { get; set; }
    protected string xml { get; set; }

    public ProcessaDados(string xml = "", string json = "")
    {
        if(!string.IsNullOrEmpty(json))
            this.json = json;

        if(!string.IsNullOrEmpty(xml))
            this.xml = xml;
        
        this.pessoas = new List<Pessoa>();
    }

    public virtual void ProcessarXML()
    {

    }

    public virtual void ProcessarJSON()
    {

    }

    protected void ApresentarDados()
    {
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"Nome: {pessoa.Nome}, CPF: {pessoa.CPF}");
            double valorTotal = pessoa.Acoes.Sum(a => a.Quantidade * a.ValorUnitario);
            Console.WriteLine($"Valor Total de ações: {valorTotal.ToString("C")}");
            foreach (var acao in pessoa.Acoes)
            {
                Console.Write(new String(' ', 4));
                Console.WriteLine($"[-] Ação: {acao.Sigla}, Quantidade: {acao.Quantidade}, Valor Unitário: {acao.ValorUnitario.ToString("C")}");
            }
        }
    }
}
