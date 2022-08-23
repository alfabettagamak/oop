using System;

public abstract class Animal
{
    public Animal(int age)
    {
        this.age = age;
    }
    
    public Animal()
    { }

    public int age;
    protected int legs;
    private bool isFur;

    public Animal(int age, int legs, bool isFur)
    {
        this.age = age;
        this.legs = legs;
        this.isFur = isFur;
    }

    public void Say()
    {
        Console.WriteLine("Animal Say");
    }

    protected bool Eat()
    {
        Console.WriteLine("EAT!!!");
        return true;
    }
    
}