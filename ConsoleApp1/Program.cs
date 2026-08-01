using DesignPatterns.PatternsComportamental.Observer;
Console.WriteLine("Curos de Design Patterns!");

//Client client = new Client(); Patterns de Criação
//client.ConsumirStudio(); Prototype 
//client.ConsumirDadosStudio(); Builder
//client.ConsumirDB(); Singleton
//client.ConsultarRotinaAluno(); abstract factory
// client.ExecultarCriacaoProduto(); FactoryMethod

//CloundComputing cloud = new CloundComputing(); // Adapter
//cloud.ProcessarContas("Janeiro"); // Adapter
//Client cliente = new Client();
//cliente.ConsumirFlyweight();

/*Client client;
Random random;
while (true)
{
    client = new Client();
    random = new Random();

    if (random.Next(2) == 1)
        client.Material = new CanetaEsferografica();
    else
        client.Material = new PincelMarcador();

    if(random.Next(3) == 1)
        client.Material.CorImplementacao = new Azul();
    else if (random.Next(3) == 2)
        client.Material.CorImplementacao = new Vermelho();
    else
        client.Material.CorImplementacao = new Preto();

    client.ConsultarNoEstoque();
    Console.WriteLine("Pressione o <Enter> para continuar...");
    ConsoleKeyInfo key = Console.ReadKey(); 
    if(key.KeyChar != 13)
        break;
}*/  //Bridge

/*Client client = new Client();
client.EfetuarCompra();//Composite*/

//Client client = new Client();
//client.ConsumirServico(); //Decorator

//FacadeManager facade = new FacadeManager();
//facade.ExecutarComplexidade(); //Facade

//Client client = new Client();
//client.ConectarVPN(); //Proxy

//Client client = new Client();
//client.ConsumirEndpointXML();
//Console.WriteLine(new String('#', 100));
//client.ConsumirEndpointJSON(); // Template Method


//Apresentar apresenta = new Apresentar();
//apresenta.ApresentarHabilidades(); // Interpreter

SendMail sendMail = new SendMail();
sendMail.EnviarEmail(); // Observer