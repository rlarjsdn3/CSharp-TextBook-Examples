using System;

public class Dog
{
    private string _name;

    public Dog(string name)
    {
        _name = name;
    }

    public string Cry()
    {
        return _name + "이(가) 멍멍";
    }
}

public class Program
{
    public static void Main()
    {
        Dog happy = new Dog("해피");
        happy.Cry();

        Dog worry = new Dog("워리");
        worry.Cry();
    }
}