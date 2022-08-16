// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.Serialization.Json;

Animal animal = new Animal();
Animal animal1 = new Animal(8, 4, true);
Animal animal2 = new Animal(15);

addAnimal("Fedor", 8, 4.5);

void addAnimal(string name, int age, double size)
{
    Console.WriteLine("добавит имя" + name);
    Console.WriteLine("добавит возраст" + age);
    Console.WriteLine("добавит размер" + size);
}

/*printSomething(false);
sum(5, 89);
Console.WriteLine(sum(5, 89));*/

/*void printSomething(bool fromConsole)
{
    string str = "";
    if (fromConsole)
    {
        Console.WriteLine("Input something");
        str = Console.ReadLine();
    }

    Console.WriteLine("You print " + str);
}


int sum(int a, int b)
{
    var c = a + b;
    return c;
}*/