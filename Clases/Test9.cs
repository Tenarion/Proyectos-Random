using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    //Los enumeradores son clases que contienen un grupo de constantes (no se pueden modificar ni cambiar).
    class Ejec
    {
        enum colores
        {
            Rojo,
            Azul,
            Verde,
            Amarillo,
            Negro
        }
        //Cada constante tiene de valor un numero especifico, comenzando por el 0. Ej: Rojo=0, Negro=4.
        static void Main()
        {
            colores color = colores.Rojo;
            switch (color)
            {
                case colores.Rojo:
                    Console.WriteLine("El color es rojo!");
                    break;
                case colores.Azul:
                    Console.WriteLine("Es azul!");
                    break;
                case colores.Verde:
                    break;
                case colores.Amarillo:
                    break;
                case colores.Negro:
                    break;
                default:
                    break;
            }
        }
    }
}