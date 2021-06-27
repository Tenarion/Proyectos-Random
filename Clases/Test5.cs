using System;

namespace Clases
{
    internal class Vehicles
    {
        public string marca = "Toyota";    
    }



    internal class Car : Vehicles
    {
        public string modelName = "Yasis";
    }

    internal class Programa
    {
        private static void Main6()
        {
            Car coche = new Car();
            Console.WriteLine("{0}, {1}", coche.marca, coche.modelName);
        }
    }
}
//Se reorganiza todo en apartados. En este caso, Vehicle es el parent, la clase general, mientras que Car es el child, una subclase de Vehicle. Util a la hora de reutilizar código y de organización.