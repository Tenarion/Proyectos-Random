using System;

namespace Proyectos_Random
{
    internal class Color
    {
        public static string intr1 = "6";
        public static string intr2 = "14";

        public static void Comando1()
        {
            Console.WriteLine("Que desea cambiar?");
            Console.WriteLine("Color fuente (1) / Color fondo (2)");
            string intr = Console.ReadLine();
            if (intr == "1")
            {
                Fuente();
            }
            else if (intr == "2")
            {
                Fondo();
            }
            else
            {
                Comando1();
            }
        }

        private static void Fuente()
        {
            Console.WriteLine("Introduce el número: ");
            Console.WriteLine("1-Rojo", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("2-Verde", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("3-Azul", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("4-Amarillo", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine("5-Morado", Console.ForegroundColor = ConsoleColor.Magenta);
            Console.WriteLine("6-Blanco", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine("7-Gris", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("8-Cyan", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.WriteLine("9-Rojo Oscuro", Console.ForegroundColor = ConsoleColor.DarkRed);
            Console.WriteLine("10-Verde Oscuro", Console.ForegroundColor = ConsoleColor.DarkGreen);
            Console.WriteLine("12-Amarillo Oscuro", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("13-Morado Oscuro", Console.ForegroundColor = ConsoleColor.DarkMagenta);
            Console.WriteLine("14-Negro", Console.ForegroundColor = ConsoleColor.Black);
            Console.WriteLine("15-Gris Oscuro", Console.ForegroundColor = ConsoleColor.DarkGray);
            Console.WriteLine("16-Cyan Oscuro", Console.ForegroundColor = ConsoleColor.DarkCyan);
            VerfCol();
            intr1 = Console.ReadLine();
            switch (intr1)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Red;
                    YN();
                    break;

                case "2":
                    Console.ForegroundColor = ConsoleColor.Green;
                    YN();
                    break;

                case "3":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    YN();
                    break;

                case "4":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    YN();
                    break;

                case "5":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    YN();
                    break;

                case "6":
                    Console.ForegroundColor = ConsoleColor.White;
                    YN();
                    break;

                case "7":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    YN();
                    break;

                case "8":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    YN();
                    break;

                case "9":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    YN();
                    break;

                case "10":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    YN();
                    break;

                case "11":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    YN();
                    break;

                case "12":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    YN();
                    break;

                case "13":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    YN();
                    break;

                case "14":
                    Console.ForegroundColor = ConsoleColor.Black;
                    YN();
                    break;

                case "15":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    YN();
                    break;

                case "16":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    YN();
                    break;

                default:
                    Console.WriteLine("Introduce un color correcto.");
                    Fuente();
                    break;
            }
        }

        private static void Fondo()
        {
            Console.WriteLine("Introduce el número: (Los cambios surgirán efecto completo una vez vuelvas al menú principal. ");
            Console.WriteLine("1-Rojo", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("2-Verde", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("3-Azul", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("4-Amarillo", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine("5-Morado", Console.ForegroundColor = ConsoleColor.Magenta);
            Console.WriteLine("6-Blanco", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine("7-Gris", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("8-Cyan", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.WriteLine("9-Rojo Oscuro", Console.ForegroundColor = ConsoleColor.DarkRed);
            Console.WriteLine("10-Verde Oscuro", Console.ForegroundColor = ConsoleColor.DarkGreen);
            Console.WriteLine("12-Amarillo Oscuro", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("13-Morado Oscuro", Console.ForegroundColor = ConsoleColor.DarkMagenta);
            Console.WriteLine("14-Negro", Console.ForegroundColor = ConsoleColor.Black);
            Console.WriteLine("15-Gris Oscuro", Console.ForegroundColor = ConsoleColor.DarkGray);
            Console.WriteLine("16-Cyan Oscuro", Console.ForegroundColor = ConsoleColor.DarkCyan);
            VerfCol();
            intr2 = Console.ReadLine();
            switch (intr2)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Red;
                    YN();
                    break;

                case "2":
                    Console.BackgroundColor = ConsoleColor.Green;
                    YN();
                    break;

                case "3":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    YN();
                    break;

                case "4":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    YN();
                    break;

                case "5":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    YN();
                    break;

                case "6":
                    Console.BackgroundColor = ConsoleColor.White;
                    YN();
                    break;

                case "7":
                    Console.BackgroundColor = ConsoleColor.Gray;
                    YN();
                    break;

                case "8":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    YN();
                    break;

                case "9":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    YN();
                    break;

                case "10":
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    YN();
                    break;

                case "11":
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    YN();
                    break;

                case "12":
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    YN();
                    break;

                case "13":
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    YN();
                    break;

                case "14":
                    Console.BackgroundColor = ConsoleColor.Black;
                    YN();
                    break;

                case "15":
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    YN();
                    break;

                case "16":
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    YN();
                    break;

                default:
                    Console.WriteLine("Introduce un color correcto.");
                    Fondo();
                    break;
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

        public static void VerfCol()
        {
            if (intr1 == "6" && intr2 == "6")
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (intr1 == "14" && intr2 == "14")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                switch (intr1)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case "5":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case "6":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case "7":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;

                    case "8":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;

                    case "9":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;

                    case "10":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;

                    case "11":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;

                    case "12":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;

                    case "13":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;

                    case "14":
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;

                    case "15":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;

                    case "16":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                }
            }
        }

        public static void VerfFond()
        {
            switch (intr2)
            {
                case "6":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case "14":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}