using System;
using System.Collections.Generic;

namespace Clases
{
    internal class Paises
    {
        private readonly string[] nombre = { "España", "Alemania", "Hungria", "Andorra" };

        private static void Man()
        {
            Paises countryEurope = new Paises();
            List<string> countries = new List<string>()
            {
                countryEurope.nombre[0],
                countryEurope.nombre[1],
                countryEurope.nombre[2],
                countryEurope.nombre[3],
            };

            foreach (var count in countries)
            {
                Console.WriteLine(count);
            }
        }
    }
}

//Primera practica, simplemente creando un objeto countryEurope, que determinará los valores de una array "nombre" en una lista "countries".