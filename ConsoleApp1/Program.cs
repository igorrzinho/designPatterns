// See https://aka.ms/new-console-template for more information
using DesignPatterns.PatternsCriacao.Singleton;
using System.Net.Http.Json;

Console.WriteLine("Curos de Design Patterns!");

Client client = new Client();
client.ConsumirDB();
//client.ConsultarRotinaAluno(); abstract factory
// client.ExecultarCriacaoProduto(); FactoryMethod