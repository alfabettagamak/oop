using System;

namespace OOP.Zombie
{
    public class ZombieSherrif : Policeman, Zombie
    {
        public void Shoot()
        {
            Console.WriteLine("BOOM!!!!");
        }

        public void Walk()
        {
            Console.WriteLine("STOMP_STOMP!!!!");
        }

        public void Growl()
        {
            Console.WriteLine("MMMMMMMMMMMMMMMMMMMM!!!!");
        }

        public void OnHold()
        {
            Console.WriteLine("........................");
        }
    }
}