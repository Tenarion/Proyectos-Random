using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Variados
{
    
    class Program
    {
        public static int pTu;
        public static int pBot;
        public static int partidas;
        static public int resultadoTu;
        static void Main()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Tú: Piedra");
                    resultadoTu = 1;
                    Bot();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Tú: Papel");
                    Bot();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Tú: Tijeras");
                    Bot();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Acción desconocida.");
                    Main();
                    break;
            }
        }
        static void Bot()
        {
            Random rnd = new Random();
            
            switch (rnd.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("Bot: Piedra");
                    System.Threading.Thread.Sleep(200);
                    switch (resultadoTu)
                    {
                        case 1:
                            Console.WriteLine("Empate!");
                            partidas++;
                            Puntuacion();
                            Re();
                            break;
                        case 2:
                            Console.WriteLine("Ganaste!");
                            partidas++;
                            pTu++;
                            Puntuacion();
                            Re();
                            break;
                        case 3:
                            Console.WriteLine("Perdiste!");
                            partidas++;
                            pBot++;
                            Puntuacion();
                            Re();
                            break;
                       
                    }
                    break;
                case 2:
                    Console.WriteLine("Bot: Papel");
                    System.Threading.Thread.Sleep(200);
                    switch (resultadoTu)
                    {
                        case 1:
                            Console.WriteLine("Perdiste!");
                            partidas++;
                            pBot++;
                            Puntuacion();
                            Re();
                            break;
                        case 2:
                            Console.WriteLine("Empate!");
                            partidas++;
                            Puntuacion();
                            Re();
                            break;
                        case 3:
                            Console.WriteLine("Ganaste!");
                            partidas++;
                            pTu++;
                            Puntuacion();
                            Re();
                            break;

                    }
                    break;
                case 3:
                    Console.WriteLine("Bot: Tijeras");
                    System.Threading.Thread.Sleep(200);
                    switch (resultadoTu)
                    {
                        case 1:
                            Console.WriteLine("Ganaste!");
                            partidas++;
                            pTu++;
                            Puntuacion();
                            Re();
                            break;
                        case 2:
                            Console.WriteLine("Perdiste!");
                            partidas++;
                            pBot++;
                            Puntuacion();
                            Re();
                            break;
                        case 3:
                            Console.WriteLine("Empate!");
                            partidas++;
                            Puntuacion();
                            Re();
                            break;

                    }
                    break;
            }
        }
        static void Re()
        {
            Console.WriteLine("Volver a jugar? (Y/N)");
            string re = Console.ReadLine();
            if (re == "Y" || re == "y")
            {
                Console.Clear();
                Main();
            }
            else if (re == "N" || re == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Re();
            }
        }
        static void Puntuacion()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Partidas     Victorias     Derrotas");
            Console.WriteLine("  {0}           {1}           {2}", partidas, pTu, pBot);
            Console.WriteLine("===================================");
        }

        }
    }

