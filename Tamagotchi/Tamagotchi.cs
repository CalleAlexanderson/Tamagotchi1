using System;
using System.Collections.Generic;
namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger;
        private int boredom;
        private List<string> words = new List<string>();
        private bool isAlive;
        private Random generator = new Random();
        public string name = "";

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

        }

        public void PrintStats() //skriver ut nuvarande hunger och bredom, och meddelar också huruvida tamagotchin lever.
        {

        }

        public void GetAlive() //returnerar värdet som isAlive har.
        {

        }

        private void ReduceBoredom() //sänker boredom.
        {

        }
    }
}