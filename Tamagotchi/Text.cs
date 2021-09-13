using System;

namespace Tamagotchi
{
    public class Text
    {
        // public string gotchiName =

        public static void GotchiName(Tamagotchi t)
        {
            Console.WriteLine();
            Console.WriteLine($"Your tamagotchis name is now {t.name}.");
        }

        public static void GotchiDead()
        {
            Console.WriteLine();
            Console.WriteLine("Oh no your tamagotchi died.");
        }

        public static void GotchiWord(Tamagotchi t)
        {
            Console.WriteLine();
            Console.Write($"What word will you teach {t.name}?");
        }

        public static void GotchiError(string gotchiName)
        {
            Console.WriteLine();
            Console.WriteLine($"You need to teach {gotchiName} a word first.");
        }

        public static void GotchiAction(Tamagotchi t)
        {
            Console.WriteLine();
            Console.WriteLine($"Chose an action for {t.name}, current actions include: Feed, Teach, Hi, Stats.");
        }
    }
}