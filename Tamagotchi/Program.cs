using System.Runtime.InteropServices;
using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tamagotchi = new Tamagotchi();

            while (tamagotchi.name == "")
            {
                tamagotchi.name = Naming.GetName();
            }

            System.Console.WriteLine($"Your tamagotchis name is now {tamagotchi.name}");
            Console.ReadLine();

        }
    }
}
