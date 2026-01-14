using System;

class Animal
{
    public void Eat() => Console.WriteLine("밥을 먹었습니다.");
}

sealed class Cat : Animal { }

// class PersianCat : Cat { }

class SealedClass
{
    static void Main()
    {
        
    }
}