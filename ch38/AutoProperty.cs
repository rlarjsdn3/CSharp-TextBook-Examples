using System;
using System.Runtime.Intrinsics.Arm;

public class Car
{
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public string Color { get; set; }
}

class AutoProperty
{
    static void Main()
    {
        Car c1 = new Car();
        c1.Name = "부가티";
        Console.WriteLine(c1.Name);

        Car c2 = new Car();
        c2.Name = "제네시스";
        c2.Color = "Black";
        Console.WriteLine($"{c2.Name} {c2.Color}");
    }
}