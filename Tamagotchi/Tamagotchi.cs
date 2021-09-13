using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.ComponentModel.Design.Serialization;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger;

        private int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
                hunger = Math.Max(hunger, 0);
            }
        }

        private int boredom;

        private int Boredom
        {
            get
            {
                return boredom;
            }
            set
            {
                boredom = value;
                boredom = Math.Max(boredom, 0);
            }
        }
        private List<string> words = new List<string>();
        private bool isAlive = true;
        private Random generator = new Random();
        public string name = "";

        public DateTime time;

        public void Feed() //sänker Hunger
        {
            Hunger -= 5;
            Tick();
        }

        public void Hi() //skriver ut ett slumpat ord från words, och anropar ReduceBoredom.
        {
            if (words.Count > 0)
            {
                int i = generator.Next(0, words.Count);
                Console.WriteLine($"{name} says {words[i]}!");
                ReduceBoredom();
            }
            else
            {
                Text.GotchiError(name);
            }
        }

        public void Teach(string word) //lägger till ett ord i words, och anropar ReduceBoredom.
        {
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()  //ökar hunger och boredom, och om någon av dem kommer över 10 så blir isAlive false.
        {

            TimeSpan dt = DateTime.Now - time;

            Hunger += Math.Max(1, ((int)dt.TotalSeconds) / 600);
            Boredom += Math.Max(1, ((int)dt.TotalSeconds) / 300);

            time = DateTime.Now;

            PrintStats();
        }

        public void PrintStats() //skriver ut nuvarande hunger och bredom, och meddelar också huruvida tamagotchin lever.
        {
            if (isAlive)
            {
                Console.WriteLine($"Current boredom: {Boredom}, hunger: {Hunger}. {name} is currently alive");
            }
        }

        public bool GetAlive() //returnerar värdet som isAlive har.
        {
            if (Boredom < 10 && Hunger < 10)
            {
                isAlive = true;
            }
            else
            {
                Console.Clear();
                isAlive = false;
                Text.GotchiDead();
            }
            return isAlive;
        }

        private void ReduceBoredom() //sänker boredom.
        {
            Boredom -= 5;
            Boredom = Math.Max(Boredom, 0);
            Tick();
        }

        public Tamagotchi()
        {
            time = DateTime.Now;
            Hunger = generator.Next(0, 4);
            Boredom = generator.Next(0, 5);
        }
    }
}