using System;

namespace EnumIndex
{
    enum Animal { Rabbit, Dragon, Snake }

    class EnumIndex
    {
        static void Main()
        {
            Animal animal = Animal.Dragon;
            int num = (int)animal;
            string str = animal.ToString();
            Console.WriteLine($"Animal.Dragon : {num}, {str}");
        }
    }
}