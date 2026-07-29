using DesignPatterns.PatternsEstruturais.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Composite;

public class Client
{
    public void EfetuarCompra()
    {
        ComponentModel product01 = new ProductLeaf("Caneca Jhon Snow", 30.0);
        ComponentModel product02 = new ProductLeaf("Camisa Jhon Snow", 50.0);
        ComponentModel product03 = new ProductLeaf("Caneca Daenerys", 30.0);
        ComponentModel product04 = new ProductLeaf("Camisa Daenerys", 50.0);
        ComponentModel product05 = new ProductLeaf("Boneco Jhon Snow", 100.0);
        ComponentModel product06 = new ProductLeaf("Boneca Daenerys", 100.0);

        ComponentModel boxJhonSnow = new ProductComposite();
        ComponentModel boxDaenerys = new ProductComposite();

        boxJhonSnow.Add(product01, product02, product05);
        boxDaenerys.Add(product03, product04, product06);

        ComponentModel boxGameOfThrones = new ProductComposite();
        boxGameOfThrones.Add(boxJhonSnow, boxDaenerys);

        var valorTotal = boxGameOfThrones.Operation();
        Console.WriteLine($"Valor total : {valorTotal.ToString("C")}");
    }
}
