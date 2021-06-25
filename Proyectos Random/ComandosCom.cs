using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_Random
{
    class ComandosCom
    {
        public static int seccion;
        public static string ComController;
        public static void CommandController()
        {
            List<string> commands = new List<string>()
            {
                "//exit",
                "//clear",
                "//restart",
            };
            
            switch (ComController)
            {
                case "//help":
                    Console.WriteLine("Los comandos generales son los siguientes:");
                    foreach (string command in commands)
                    {
                        int length = command.Length;
                        Console.WriteLine(command);
                        Console.WriteLine("{0}", string.Concat(Enumerable.Repeat("-", length)));
                    }
                    Program.Introducir();
                    break;
                case "//exit":
                    Environment.Exit(0);
                    break;
                case "//clear":
                    Clear.Comando1();
                    break;
                case "//restart":
                    Restart.Comando1();
                    break;
                default:
                    switch (seccion)
                    {
                        case 1:
                            Console.WriteLine("Comando incorrecto");
                            seccion = 0;
                            Program.Introducir();
                            break;
                    }
                    break;
            }
        }
    }
}