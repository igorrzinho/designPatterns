using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.Singleton
{
    public class Client
    {
        public void ConsumirDB()
        {
            var instancia = ContextDB.Instancia;
            instancia.ExecultaQuery("SELECT * FROM Nome_Tabela");

            instancia = ContextDB.Instancia;
            instancia.ExecultaQuery("UPDATE Nome_Tabela SET Coluna1 = Valor1 WHERE Condicao");

            instancia = ContextDB.Instancia;
            instancia.ExecultaQuery("DELETE FROM Nome_Tabela WHERE Condicao");
        }
    }
}
