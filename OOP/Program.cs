// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using OOP;
using OOP.Adapter;
using OOP.Builder;
using OOP.singleton;
using OOP.Zombie;

First first = new First();
Second second = new Second();

Adapter adapter = new Adapter(second);
adapter.processFOO(first.RandomGenerate());


/*Builder builder = new Builder();
var newPerson = builder.WithName("Ivan")
    .WithMiddleName("Andreevich")
    .WithSurname("Petrov").build();

Console.WriteLine("person Name " + newPerson.name);*/

//Console.WriteLine(Factorial.Fact(5));

/*
var dateTime = "23.08.2022 19:46:44";
Console.WriteLine(DateTime.ParseExact(dateTime, "dd.MM.yyyy HH:mm:ss", null));
*/


/*
Bad bad = new Bad();
List<Exception> errors = new List<Exception>();
for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine(bad.flaky());
    }
    catch (Exception e)
    {
        Console.WriteLine("Catch block");
        errors.Add(e);
    }
}

foreach (Exception err in errors)
{
    Console.WriteLine(err.Message);
}
*/

    
/*
try
{
    Console.WriteLine("Введите число");
    int a = Int32.Parse(Console.ReadLine());
    int b = 0;
    Console.WriteLine(a / b);
}
catch (DivideByZeroException exception)
{
    Console.WriteLine("in CATCH! DivideByZeroException" + exception.Message);
    throw;
}
catch (FormatException exception)
{
    Console.WriteLine("in CATCH! FormatException");
}
finally
{
    Console.WriteLine("FINALLY");
}
*/

/*
DateTime dateTime = new DateTime(2020, 8, 25);

var dateTime1 = DateTime.Now;
Console.WriteLine(dateTime1);
var newDate = dateTime1.AddMonths(-5);
Console.WriteLine(newDate);
Console.WriteLine(newDate.ToString("dd/M/yyyy"));
*/

/*
 int[] arr = new[] {2, 3, 5, 1, 3};

List<Cat> cats = new List<Cat>();
cats.Add(new Cat(10));
cats.Add(new Cat(1));
cats.Add(new Cat(4));
cats.Add(new Cat(15));

List<int> numbers = new List<int>();
numbers.Add(5);
numbers.Add(1);
numbers.Add(2);
numbers.Add(1);

numbers.Sort();

/*
var db = Database.GetDatabase();
var db1 = Database.GetDatabase();

Console.WriteLine(db == db1);

Cat.ololo();
*/

/*
 ClassicZombie zombie = new ClassicZombie();
zombie.Walk();

Sherrif sherrifKarl = new Sherrif();
sherrifKarl.Shoot();

ZombieSherrif zombieSherrif = new ZombieSherrif();
zombieSherrif.Shoot();

Car car = new Car(zombie);
car.ZombieDriver.Walk();

Car car1 = new Car(zombieSherrif);
car1.ZombieDriver.Walk();

Cat cat = new Cat();
/*
Animal animal = new Animal();
animal.age = 25;
Animal animal1 = new Animal(8, 4, true);
Animal animal2 = new Animal(15);

Dog dog = new Dog();
dog.say();


var a = 4;

void addAnimal(string name, int age, double size)
{
    Console.WriteLine("добавить имя" + name +  " !");
    Console.WriteLine("добавить возраст" + age +  " !");
    Console.WriteLine("добавить размер" + size +  " !");
}
*/

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
