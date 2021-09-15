using System.Threading;
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
            string word;


            while (tamagotchi.name == "")
            {
                tamagotchi.name = Naming.GetName();
            }

            Text.GotchiName(tamagotchi);

            while (tamagotchi.GetAlive())
            {
                Console.WriteLine();
                Text.GotchiAction(tamagotchi);

                action = Console.ReadLine().ToLower();

                if (action == "feed")
                {
                    tamagotchi.Feed();
                }

                if (action == "stats")
                {
                    tamagotchi.PrintStats();
                }

                if (action == "hi")
                {
                    tamagotchi.Hi();
                }

                if (action == "teach")
                {
                    Console.WriteLine();
                    Text.GotchiWord(tamagotchi);
                    word = Console.ReadLine();
                    tamagotchi.Teach(word);
                }

                if (action == "")
                {
                    tamagotchi.Tick();
                }
            }

            Console.ReadLine();
        }
    }
}
