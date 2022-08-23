using System;

namespace OOP.Zombie
{
    public class FastZombie : Zombie
    {
        public void Walk()
        {
            Console.WriteLine("Fast-Stomp-stomp-stomp");
        }

        public void Growl()
        {
            Console.WriteLine("arrrrrrrrrr!!");
        }

        public void OnHold()
        {
            Console.WriteLine("Z-Z-Z-Z-Z-z-z!");
        }

        public void Run()
        {
            Console.WriteLine("RUN!!!!!!!!!");
        }
    }
}