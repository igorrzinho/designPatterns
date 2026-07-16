using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstruturais.Adapter
{
    public class BusinessLegado
    {
        public string ExecutarRotinaContasPagar(string mes)
        {
            var result = AcessoSQL.GetDadosPagar(mes);
            Console.WriteLine("Processando Regras de negocios Contas a pagar");
            //Aplicando regras de negócios contas a pagar
            Thread.Sleep(30000);
            return result;
        }

        public string ExecutarRotinaContasReceber(string mes)
        {
            var result = AcessoSQL.GetDadosReceber(mes);
            Console.WriteLine("Processando Regras de negocios Contas a receber");
            //Aplicando regras de negócios contas a receber
            Thread.Sleep(30000);
            return result;
        }
    }

    public class AcessoSQL
    {
        public static string GetDadosPagar(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Janeiro", "Mes: Janeiro \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 100.00 \nContato: (11)99999-9999");
            dic.Add("Fevereiro", "Mes: Fevereiro \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 100.00 \nContato: (11)99999-9999");
            dic.Add("Março", "Mes: Março \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 100.00 \nContato: (11)99999-9999");
            dic.Add("Abril", "Mes: Abril \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 100.00 \nContato: (11)99999-9999");
            dic.Add("Maio", "Mes: Maio \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 100.00 \nContato: (11)99999-9999");
            dic.Add("Junho", "Mes: Junho \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 100.00 \nContato: (11)9999 nine - nine nine nine nine");
            dic.Add("Agosto", "Mes: Agosto \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 10０.００ \nContato: (１１)９９９９９-９９９９");
            dic.Add("Setembro", "Mes: Setembro \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 10０.００ \nContato: (１１)９９９９９-９９９９");
            dic.Add("Outubro", "Mes: Outubro \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 10０.００ \nContato: (１１)９９９９９-９９９９");
            dic.Add("Novembro", "Mes: Novembro \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 10０.００ \nContato: (１１)９９９９９-９９９９");
            dic.Add("Dezembro", "Mes: Dezembro \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 10０.００ \nContato: (１１)９９９９９-９９９９");

            return dic[mes];
        }
        public static string GetDadosReceber(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Janeiro", "Mes: Janeiro \nCNPJ:01.234.567/0001-89 \nRazão Social: Recebimento LTDA \nValor: 100.00 \nContato: (11)99999-9999");
            dic.Add("Fevereiro", "Mes: Fevereiro \nCNPJ:01.234.567/0001-89 \nRazão Social: Recebimento LTDA \nValor: 100.00 \nContato: (11)99999-9999");
            dic.Add("Março", "Mes: Março \nCNPJ:01.234.567/0001-89 \nRazão Social: Recebimento LTDA \nValor: 100.00 \nContato: (11)99999-9999");
            dic.Add("Abril", "Mes: Abril \nCNPJ:01.234.567/0001-89 \nRazão Social: Recebimento LTDA \nValor: 100.00 \nContato: (11)99999-9999");
            dic.Add("Maio", "Mes: Maio \nCNPJ:01.234.567/0001-89 \nRazão Social: Recebimento LTDA \nValor: 100.00 \nContato: (11)99999-9999");
            dic.Add("Agosto", "Mes: Agosto \nCNPJ:01.234.567/0001-89 \nRazão Social: Recebimento LTDA \nValor: 100.00 \nContato: (１１)99999-9999");
            dic.Add("Setembro", "Mes: Setembro \nCNPJ:01.234.567/0001-89 \nRazão Social: Recebimento LTDA \nValor: 100.00 \nContato: (１１)99999-9999");
            dic.Add("Outubro", "Mes: Outubro \nCNPJ:01.234.567/0001-89 \nRazão Social: Recebimento LTDA \nValor: 100.00 \nContato: (１１)99999-9999");
            dic.Add("Novembro", "Mes: Novembro \nCNPJ:01.234.567/0001-89 \nRazão Social: Recebimento LTDA \nValor: 100.00 \nContato: (１１)99999-9999");
            dic.Add("Dezembro", "Mes: Dezembro \nCNPJ:01.234.567/0001-89 \nRazão Social: Exemplo LTDA \nValor: 10０.００ \nContato: (１１)９９９９９-９９９９");

            return dic[mes];
        }
    }
}
