using DesignPatterns.PatternsEstruturais.Adapter;

Console.WriteLine("Curos de Design Patterns!");

//Client client = new Client(); Patterns de Criação
//client.ConsumirStudio(); Prototype 
//client.ConsumirDadosStudio(); Builder
//client.ConsumirDB(); Singleton
//client.ConsultarRotinaAluno(); abstract factory
// client.ExecultarCriacaoProduto(); FactoryMethod

CloundComputing cloud = new CloundComputing();
cloud.ProcessarContas("Janeiro");