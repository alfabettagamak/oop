using System;

namespace OOP
{
    public class Dog : Animal
    {

        public void Sleep()
        {
            Console.WriteLine("SLEEEP");
            Console.Write(base.legs);
        }

        public void Say()
        {
            Console.WriteLine("Gav-Gav");
        }
        
        
    }
}