using System;

namespace Tamagotchi
{
    public class Text
    {
        // public string gotchiName =

        public static void GotchiName(Tamagotchi t)
        {
            Console.WriteLine($"Your tamagotchis name is now {t.name}");
        }
    }
}