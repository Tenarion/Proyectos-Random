using System;

namespace Clases
{
    //Mismo caso que en Test 2, solo que utilizando parámetros y constructores, y dandole valor a un nuevo objeto Honda.
    //Al usar los constructores con parametros, podemos depender de solamente 1 string color para determinar el color de ambos objetos, sin tener que crear strings para cada uno.
    internal class Car
    {
        public string color;
        public int speed = 200;

        public Car(string colorCoches)
        {
            color = colorCoches;
        }

        public static void MaxSpeed()
        {
            Console.WriteLine("Calmese porfavor tengo familia e hijos.");
        }
    }

    internal class ReadInfo
    {
        private static void Mn()
        {
            Car Toyota = new Car("Rojo");
            Car Honda = new Car("Azul");
            Console.WriteLine("El color de los coches es {0} y {1} respectivamente.", Toyota.color, Honda.color);
            if (Toyota.speed > 200 || Honda.speed > 190)
            {
                Car.MaxSpeed();
            }
            else
            {
                Console.WriteLine("Su velocidad es de {0} y de {1}!", Toyota.speed, Honda.speed);
            }
        }
    }
}
}