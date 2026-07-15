// See https://aka.ms/new-console-template for more information
using DesignPatterns.PatternsCriacao.Builder;
using System.Net.Http.Json;

Console.WriteLine("Curos de Design Patterns!");

Client client = new Client();
client.ConsumirDadosStudio();
//client.ConsumirDB(); Singleton
//client.ConsultarRotinaAluno(); abstract factory
// client.ExecultarCriacaoProduto(); FactoryMethod