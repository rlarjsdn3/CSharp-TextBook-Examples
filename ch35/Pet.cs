using System;

class Pet
{
    private string _name;

    public Pet(string name) => _name = name;

    public override string ToString()
    {
        return _name;
    }
}

class Program
{
    static void Main()
    {
        var pet = new Pet("고양이");
        Console.WriteLine(pet.ToString());
    }
}