using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Matematicas_asco
{
    class Pitagoras
    {
        public static void Pit()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a la calculadora pitagórica!");
            Console.WriteLine("Aquí podras calcular la hipotenusa o cualquier cateto dado de un triangulo.");
            Console.ReadKey();
            Introducir();

        }

        static void Introducir()
        {
            Console.WriteLine("Que quieres calcular?");
            Console.WriteLine("1-Hipotenusa");
            Console.WriteLine("2-Cateto");
            string conv = Console.ReadLine();
            switch (conv)
            {
                case "1":
                    CalcHip();
                    break;
                case "2":
                    CalcCat();
                    break;
                default:
                    Introducir();
                    break;
            }

        }
        static void CalcHip()
        {
            
            Console.WriteLine("Introduce el cateto 1:");
            bool cat1 = double.TryParse(Console.ReadLine(), out double cate1);
            Console.WriteLine("Introduce el cateto 2:");
            bool cat2 = double.TryParse(Console.ReadLine(), out double cate2);
            double mult = Math.Pow(cate2, 2) + Math.Pow(cate1, 2);
            if (cat1 && cat2)
            {
                Console.WriteLine("La hipotenusa es {0}", Math.Sqrt(mult));
            }
            else
            {
                Console.WriteLine("Introduce números válidos");
                CalcHip();
            }

        }
        static void CalcCat()
        {
            Console.WriteLine("Introduce la hipotenusa:");
            bool hip1 = double.TryParse(Console.ReadLine(), out double hipo1);
            Console.WriteLine("Introduce el cateto:");
            bool cat2 = double.TryParse(Console.ReadLine(), out double cate2);
            double mult = Math.Pow(hipo1, 2) - Math.Pow(cate2, 2);
            if (hip1 && cat2)
            {
                Console.WriteLine("El cateto es {0}", Math.Sqrt(mult));
            }
            else
            {
                Console.WriteLine("Introduce números válidos");
                CalcCat();
            }
        }
    }
}
