using System;

class My { }

class Your
{
    public override string ToString()
    {
        return "새로운 반환 문자열 지정";
    }
}

class ToStringMethod
{
    static void Main()
    {
        My my = new My();
        Console.WriteLine(my);

        Your your = new Your();
        Console.WriteLine(your);
    }
}