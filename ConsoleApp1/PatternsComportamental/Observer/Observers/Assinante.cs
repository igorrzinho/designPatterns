using DesignPatterns.PatternsComportamental.Observer.Interfaces;
using DesignPatterns.PatternsComportamental.Observer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.Observer.Observers;

public class Assinante : IObservavel
{
    public Assinante(Pessoa pessoa, string messagem)
    {
        Pessoa = pessoa;
        Messagem = messagem;
    }

    public Pessoa Pessoa { get; set; }
    public string Messagem { get; set; }

    public void Update()
    {
        // Simular envio de email para assinante
        Console.WriteLine($"Enviando email para {Pessoa.Email}\n");
        Console.WriteLine($"Prezado {Pessoa.Nome} \n {Messagem}");

        // Simula o registro no banco
        Console.WriteLine($"INSERT INTO TB_NOTIFICACAO (PessoaId, Notifica, Mensagem, Data) \n VALUES ({Pessoa.Id}, 1, '{Messagem}', '{DateTime.Now:yyyy-MM-dd}')");
    }
}
