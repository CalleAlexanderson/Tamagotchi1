using System.Runtime.InteropServices;
using System;
namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tamagotchi = new Tamagotchi();
            string action;


            while (tamagotchi.name == "")
            {
                tamagotchi.name = Naming.GetName();
            }

            Text.GotchiName(tamagotchi);

            while (tamagotchi.GetAlive())
            {
                action = Console.ReadLine();
            }

            System.Console.WriteLine("Oh no your tamagotchi died");

            Console.ReadLine();
        }
    }
}
