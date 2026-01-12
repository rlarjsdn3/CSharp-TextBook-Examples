using System;

abstract class Animal
{
    public string Name { get; }

    protected Animal(string name)
    {
        Name = name;
    }

    public void Introduce()
    {
        Console.WriteLine($"I am {Name}");
    }

    public abstract void MakeSound();
}

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Dog : Animal, ISwimmable
{
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!"); 
    }

    public void Swim()
    {
        Console.WriteLine("Dog is swimming");
    }
}

class Eagle : Animal, IFlyable
{
    public string Age { get; init; }
    public Eagle(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Screech!");
    }

    public void Fly()
    {
        Console.WriteLine("Eagle is flying");
    }
}

class Duck : Animal, IFlyable, ISwimmable
{
    public Duck(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Quack!");
    }

    public void Fly()
    {
        Console.WriteLine("Duck is flying");
    }

    public void Swim()
    {
        Console.WriteLine("Duck is swimming");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog("Buddy");
        dog.Introduce();
        dog.MakeSound();

        IFlyable bird = new Eagle("Sky");
        bird.Fly();

        Duck duck = new Duck("Donald");
        duck.MakeSound();
        duck.Swim();

        if (duck is IFlyable flyable)
        {
            flyable.Fly();
        }
    }
}