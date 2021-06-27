using System;

namespace Clases
{
    internal class Car
    {
        public string color = "red";
        public int speed = 200;

        public static void MaxSpeed()
        {
            Console.WriteLine("Calmese porfavor tengo familia e hijos.");
        }
    }

    //En este caso determinamos las variables de nuestro objeto en una clase diferente, dandole color, speed, y un metodo de MaxSpeed.
    //Al momento de leer estas variables, se crea un objeto en otra clase y podremos definir todas las mismas utilizando exclusivamente el objeto dado.
    internal class ReadInfo
    {
        private static void Mn()
        {
            Car Toyota = new Car();
            Console.WriteLine("El color del coche es {0}", Toyota.color);
            if (Toyota.speed > 200)
            {
                Car.MaxSpeed();
            }
            else
            {
                Console.WriteLine("Su velocidad es de {0}!", Toyota.speed);
            }
        }
    }
}

//Si se hiciera de forma novata y desorganizada, quedaría algo así:
internal class ReadInfo
{
    private static string color = "red";
    private static int speed = 200;

    private static void Mn1()
    {
        Console.WriteLine("El color del coche es {0}", color);
        if (speed > 200)
        {
            Console.WriteLine("Calmese porfavor tengo familia e hijos");
        }
        else
        {
            Console.WriteLine("Su velocidad es de {0}!", speed);
        }
    }

    //Funcional? Lo es. Pero a la hora de utilizar múltiples objetos es muy ineficiente, y ahi debemos dar uso a los objetos, constructores y parametros.
}