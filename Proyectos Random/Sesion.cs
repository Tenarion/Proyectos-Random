using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyectos_Random
{
    class Session
    {
        public static string user;
        public static string pass;
        public static string path = @"c:\temp\cred.txt";

        public static void Sesion()
        {
            if (!File.Exists(path))
            {
                string usuario = user + Environment.NewLine;
                File.WriteAllText(path, usuario);
                string contraseña = pass + Environment.NewLine;
                File.AppendAllText(path, contraseña);
            }
        }
        static void Main()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Inicia sesión aquí: ");
                Console.Write("Usuario: ");
                user = Console.ReadLine();
                Console.Write("Contraseña: ");
                pass = Console.ReadLine();
                if (user == File.ReadLines(path).First() && pass == File.ReadLines(path).Last())
                {
                    Console.WriteLine("Inicio de sesión correcto!");
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    Program.Main1();
                }
                else
                {
                    Console.WriteLine("Credenciales incorrectos, intentalo de nuevo.");
                    Main();
                }
            }
            else
            {
                Console.WriteLine("Crea una nueva cuenta aquí: ");
                Console.Write("Usuario: ");
                user = Console.ReadLine();
                if (user.Length >= 14)
                {
                    Console.WriteLine("Usuario demasiado largo.");
                    Main();
                }
                else if (user.Any(Char.IsSymbol))
                {
                    Console.WriteLine("El usuario no puede contener caracteres especiales.");
                }
                Console.Write("Contraseña: ");
                pass = Console.ReadLine();
                Console.WriteLine("Gracias por registrate!");
                Sesion();
                Main();
                }
            }

        }
    }
