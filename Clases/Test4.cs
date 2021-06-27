using System;

namespace Clases
{
    internal class Almeja
    {
        private string pepe;

        public string Pepe
        {
            get { return pepe; }
            set { pepe = value; }
        }
    }

    internal class Prueba
    {
        private static void Main()
        {
            Almeja nombrePersona = new Almeja();

            Console.WriteLine(nombrePersona.Pepe);
        }
    }

    //Tenemos una private string "pepe", y mediante las propiedades podemos hacer una puerta de acceso a la misma pese a ser privada, utilizando una public string "Pepe" con un cuerpo definido usando get y set.
    //Con get, obtenemos el valor de la privada, y con set se lo aplicamos a la publica, por tanto tiene el mismo valor.
    internal class Almeja1
    {
        public string Pepe
        { get; set; }
    }

    internal class Prueba1
    {
        private static void Main5()
        {
            Almeja1 nombrePersona = new Almeja1();

            Console.WriteLine(nombrePersona.Pepe);
        }
    }
}

//Mismo caso, pero simplificado, sin definir una privada.