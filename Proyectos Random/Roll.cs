using System;

namespace Proyectos_Random
{
    internal class Roll
    {
        public static void Comando1()
        {
            Console.Write("Introduce X: ");
            int.TryParse(Console.ReadLine(), out int v1);
            Console.Write("Introduce Y: ");
            int.TryParse(Console.ReadLine(), out int v2);
            bool resultado = Convert.ToBoolean(v1 & v2);
            Random rnd = new Random();

            if (resultado == false)
            {
                Console.WriteLine("Combinación incorrecta.");
                Comando1();
            }
            else if (v1 > v2)
            {
                Console.WriteLine("El primer valor no puede ser más grande que el segundo dado.");
                Comando1();
            }
            else
            {
                Console.WriteLine("El valor es: {0} ", rnd.Next(v1, v2));
                YN();
            }
        }

        private static void YN()
        {
            Console.Write("Seguir? (Y/N): ");
            string yn = Console.ReadLine();
            if (yn == "Y")
            {
                Comando1();
            }
            else if (yn == "N")
            {
                Console.Clear();
                Program.Main1();
            }
            else
            {
                YN();
            }
        }
    }
}