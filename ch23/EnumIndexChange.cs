using System;

enum Animal
{
    Horse,
    Sheep = 5,
    Monkey
}

class EnumIndexChange
{
    static void Main()
    {
        Console.WriteLine((int)Animal.Monkey);
    }
}