using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Test8
    {
        // Interface
        interface IAnimal
        {
            void animalSound(); // interface method (does not have a body)
        }

        // Pig "implements" the IAnimal interface
        class Pig : IAnimal
        {
            public void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Program
        {
            static void Main9(string[] args)
            {
                Pig myPig = new Pig();  // Create a Pig object
                myPig.animalSound();
            }
        }
    }
}
//Interfaces. Abstractas puramente, ni idea.