using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_Random
{

    class Program
    {
        public static void Main1()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==============================");
            Console.WriteLine("       COMMAND MANAGER");
            Console.WriteLine("==============================");
            List<string> commands = new List<string>
            {
                "/roll: Genera un número aleatorio entre x e y",
                "/color: Cambia el color de la terminal",
                "/hour: Determina la fecha y hora del PC.",
                "/search: Busca cualquier cosa en diferentes buscadores.",
            };
            Color.VerfFond();
            foreach (string command in commands)
            {
                int length = command.Length;
                Console.WriteLine(command);
                Console.WriteLine("{0}", string.Concat(Enumerable.Repeat("-", length)));
            }
            Introducir();

        }
        public static void Introducir()
        {
            Color.VerfCol();
            string intr = Console.ReadLine();
            if (intr.StartsWith("//"))
            {
                ComandosCom.seccion = 1;
                ComandosCom.ComController = intr;
                ComandosCom.CommandController();
            }
            else
            {
                switch (intr)
                {
                    case "/roll":
                        Roll.Comando1();
                        break;
                    case "/color":
                        Color.Comando1();
                        break;
                    case "/hour":
                        Hour.Comando1();
                        break;
                    case "/search":
                        Search.Comando1();
                        break;
                    default:
                        Console.WriteLine("Comando incorrecto, intentelo de nuevo.");
                        Introducir();
                        break;
                }

            }

        }
    }
}
