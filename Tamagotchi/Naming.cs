using System;

namespace Tamagotchi
{
    public class Naming
    {
        public static string GetName()
        {
            string input1 = "yes";
            string tempName = "";
            while (input1 == "yes")
            {
                System.Console.Write("Name your tamagotchi: ");
                tempName = Console.ReadLine();
                System.Console.WriteLine($"Your tamagotchis name is {tempName}, do you want to change it? If so write yes otherwise press enter.");
                input1 = Console.ReadLine().ToLower();
            }

            return tempName;
        }
    }
}