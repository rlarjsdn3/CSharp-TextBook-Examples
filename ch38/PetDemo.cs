using System;

class Pet
{
    public int Weight { get; set; }

    public void Feed(int weight)
    {
        Weight += weight;
    }
}

class PetDemo
{
    static  void Main()
    {
        Pet pet = new Pet();
        pet.Weight = 50;
        pet.Feed(10);
        Console.WriteLine(pet.Weight);
    }
}