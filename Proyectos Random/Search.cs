using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_Random
{
    class Search
    {
        public static void Comando1()
        {
            Console.WriteLine("Elige un buscador:");
            Console.WriteLine("1-Google");
            Console.WriteLine("2-DuckDuckGo");
            string select = Console.ReadLine();
            if (select == "1")
            {
                Console.Write("Buscando en Google: ");
                string search = Console.ReadLine();
                System.Diagnostics.Process.Start("http://www.google.com/search?q=" + search);
            }
            else if (select == "2")
            {
                Console.Write("Buscando en DuckDuckGo: ");
                string search = Console.ReadLine();
                System.Diagnostics.Process.Start("https://duckduckgo.com/?q=" + search);
            }
       
        }
    }
}
