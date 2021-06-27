using System;

namespace Clases
{
    internal class Vehicles
    {
        public virtual void modelName()
        {
            Console.WriteLine("Los vehiculos tienen muchos modelos.");
        }
    }

    internal class Toyota : Vehicles
    {
        public override void modelName()
        {
            Console.WriteLine("Yasis");
        }

    }
    internal class Honda : Vehicles
    {
        public override void modelName()
        {
            Console.WriteLine("Lapa");
        }

    }
    internal class Audi : Vehicles
    {
        public override void modelName()
        {
            Console.WriteLine("Cigueña");
        }

    }
    class Ejecucion
    {
        static void Main7()
        {
            Vehicles myVehicle = new Vehicles();
            Vehicles myToyota = new Toyota();
            Vehicles myHonda = new Honda();
            Vehicles myAudi = new Audi();

            myVehicle.modelName();
            myToyota.modelName();
            myHonda.modelName();
            myAudi.modelName();
        }
    }
}
//Usando polimorfismo. Se usa inheritance pero multiples veces. Asi podemos crear childs de diferentes cosas, y luego llamar al metodo directamente en nuestra ejecución.

