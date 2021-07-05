using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematicas_asco
{
    class Program
    {
        static void Main()
        {
            List<string> Opciones = new List<string>() { "1-Pitagoras", "2-Raiz cuadrada", "3-Logaritmo", "4-División", "5-Multiplicación" };
            Console.WriteLine("Elige que acción quieres hacer:");
            foreach (var Opcion in Opciones)
            {
                Console.WriteLine(Opcion);
            }
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Pitagoras.Pit();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Elige una opción correcta.");
                    break;
            }


        }
    }
}
