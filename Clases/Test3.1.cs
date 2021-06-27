using System;
using System.Collections.Generic;

namespace Clases
{
    internal class Paises
    {
        private readonly string nombre;

        public Paises(string nombrePais)
        {
            nombre = nombrePais;
        }

        private static void Man()
        {
            Paises countryEurope = new Paises();
            List<string> countries = new List<string>()
            {
                countryEurope.nombre("España"),
                countryEurope.nombre("Alemania",
                countryEurope.nombre("Hungria"),
                countryEurope.nombre("Andorra")
            };

            foreach (var count in countries)
            {
                Console.WriteLine(count);
            }
        }
    }
}

//Test 1 pero utilizando constructores y parametros.