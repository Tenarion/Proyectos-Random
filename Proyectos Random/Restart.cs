using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_Random
{
    class Restart
    {
        public static void Comando1()
        {
            string[] cons = { "6", "14" };

            Color.intr1 = cons[0];
            Color.intr2 = cons[1];
            Console.Clear();
            Program.Main1();
        }
    }
}
