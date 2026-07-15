using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.Singleton
{
    public class ContextDB
    {
        private static ContextDB _instancia = null;
        private ContextDB()
        { }

        // Vai criar apenas uma vez a instancia do ContextDB, e vai retornar a mesma instancia para todos que chamarem o método Instancia.
        public static ContextDB Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ContextDB();
                    Console.WriteLine("Instancia Criada");
                }
                return _instancia;
            }
        }

        public void ExecultaQuery(string query) 
        {
            Console.WriteLine(query);
        }
    }
}
