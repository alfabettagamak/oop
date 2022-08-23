using System;

namespace OOP
{
    public class Cat : Animal
    {
        public Cat(int age1)
        {
            age = age1;
        }

        public void Say()
        {
            Console.WriteLine("Meow!");
        }

        public static void ololo()
        {
            Console.WriteLine("OLOLOLOL");
        }
    }
}