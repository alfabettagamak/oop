
using System;

class Factorial
{
    public static int Fact(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Fact(n - 1);
    }
}
//5! = 1*2*3*4*5

class Bad
{
    public int a = 0;

    public int flaky()
    {
        Random rnd = new Random();
        a = rnd.Next(10);
        a /= rnd.Next(2);
        return a;
    }
}
