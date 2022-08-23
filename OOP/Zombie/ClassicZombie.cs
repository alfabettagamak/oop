using System;

namespace OOP.Zombie
{
    public class ClassicZombie : Zombie
    {
        public void Walk()
        {
            Console.WriteLine("Stomp-stomp");
        }

        public void Growl()
        {
            Console.WriteLine("braaaaiiiins!!");
        }

        public void OnHold()
        {
            Console.WriteLine("z-z-z-z-z-z-z!");
        }
    }
}