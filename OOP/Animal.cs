using System;

class Animal
{
    public Animal(int age)
    {
        this.age = age;
    }
    
    public Animal()
    { }

    private int age;
    private int legs;
    private bool isFur;

    public Animal(int age, int legs, bool isFur)
    {
        this.age = age;
        this.legs = legs;
        this.isFur = isFur;
    }

    void say(string a)
    {
        Console.WriteLine(a);
    }

    bool eat()
    {
        Console.WriteLine("EAT!!!");
        return true;
    }
    
}