using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger;
        private int boredom;
        private List<string> words = new List<string>();
        private bool isAlive = true;
        private Random generator = new Random();
        public string name = "";

        public DateTime time;

        public void Feed() //sänker Hunger
        {

        }

        public void Hi() //skriver ut ett slumpat ord från words, och anropar ReduceBoredom.
        {

        }

        public void Teach(string words) //lägger till ett ord i words, och anropar ReduceBoredom.
        {

        }

        public void Tick()  //ökar hunger och boredom, och om någon av dem kommer över 10 så blir isAlive false.
        {

            TimeSpan dt = DateTime.Now - time;

            hunger += ((int)dt.TotalSeconds) / 300;



            time = DateTime.Now;


        }

        public void PrintStats() //skriver ut nuvarande hunger och bredom, och meddelar också huruvida tamagotchin lever.
        {
            Console.WriteLine($"Current boredom: {boredom}, hunger: {hunger}. {name} is currently alive");
        }

        public bool GetAlive() //returnerar värdet som isAlive har.
        {
            if (boredom < 10 || hunger < 10)
            {
                isAlive = true;
            }
            else
            {
                isAlive = false;
            }
            return isAlive;
        }

        private void ReduceBoredom() //sänker boredom.
        {

        }

        public Tamagotchi()
        {
            time = DateTime.Now;
            hunger = generator.Next(0, 3);
            boredom = generator.Next(0, 5);
        }
    }
}