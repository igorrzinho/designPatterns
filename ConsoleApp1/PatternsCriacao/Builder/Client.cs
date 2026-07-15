using DesignPatterns.PatternsCriacao.Builder.Builders;
using DesignPatterns.PatternsCriacao.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.Builder
{
    public class Client
    {
        public void ConsumirDadosStudio() 
        { 
            Director director = new Director();
            StudioBuilder studioBuilder;
            Studio studio;

            studioBuilder = new Studio24mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ExibirInformacoesStudio(studio, "24m²");

            studioBuilder = new Studio26mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ExibirInformacoesStudio(studio, "26m²");

            studioBuilder = new Studio28mBuilder();
            director.ConstruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ExibirInformacoesStudio(studio, "28m²");
        }
        private void ExibirInformacoesStudio(Studio studio, string studioM)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Studio {studioM}:");
            Console.WriteLine($"Tipo de Piso: {studio.TipoPiso}");
            Console.WriteLine($"Tipo de Financiamento: {studio.TipoFinanciamento}");
            Console.WriteLine($"Valor do Studio: {studio.ValorStudio.ToString("C")}");
        }

    }
}
