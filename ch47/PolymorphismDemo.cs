using System;
using System.Runtime.InteropServices.Marshalling;

namespace PolymorphismDemo
{
    public abstract class Animal
    {
        public abstract string Cry();
    }

    public class Dog : Animal
    {
        public override string Cry()
        {
            return "Woof!";
        }
    }

    public class Cat : Animal
    {
        public override string Cry()
        {
            return "Meow!";
        }
    }

    public class Trainer
    {
        public string MakeCry(Animal animal)
        {
            return animal.Cry();
        }
    }

    class PolymorphismDemo
    {
        static void Main()
        {
            Console.WriteLine($"{(new Dog().Cry())}");
            Console.WriteLine($"{(new Cat().Cry())}");

            Animal dog = new Dog();
            Console.WriteLine($"{dog.Cry()}");
            Animal cat = new Cat();
            Console.WriteLine($"{cat.Cry()}");

            Trainer trainer = new Trainer();
            Console.WriteLine($"{trainer.MakeCry(dog)}");
            Console.WriteLine($"{trainer.MakeCry(cat)}");
        }
    }

}