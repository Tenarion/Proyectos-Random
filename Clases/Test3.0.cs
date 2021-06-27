using System;

namespace Clases
{
    internal class Cars
    {
        public string model;

        public Cars(string modelName)
        {
            model = modelName;
        }

        private static void Mailn()
        {
            Cars Ford = new Cars("Mustang");
            Console.WriteLine(Ford.model);
            Cars Toyota = new Cars("Yarsis");
            Console.WriteLine(Toyota.model);
        }
    }

    //La superior, es la misma que la inferior solo que mas organizada y simplificada, utilizando parámetros en los constructores. El parametro usado es modelName, que indica el modelo dependiendo de que objeto indicamos.
    //Al indicar modelName, podemos darle un valor especifico al mismo dependiendo del objeto, como se ve en Cars("Mustang"), Cars("Yarsis").
    //En el inferior, los modelos se especifican en 2 strings diferentes, se puede ver el caso, que acaba llenando mas código que el primero, ya que debemos crear una string para cada objeto.
    internal class Carss
    {
        public string model1;
        public string model2;

        public Carss()
        {
            model1 = "Mustang";
            model2 = "Yarsis";
        }

        private static void Main4()
        {
            Carss Ford = new Carss();
            Console.WriteLine(Ford.model1);
            Carss Toyota = new Carss();
            Console.WriteLine(Toyota.model2);
        }
    }
}