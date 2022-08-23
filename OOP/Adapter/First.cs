using System;

namespace OOP.Adapter
{
    public class First
    {
        private Random rnd = new Random();
        public int number;

        public int RandomGenerate()
        {
            number = rnd.Next(1000);
            return number;
        }
    }
}