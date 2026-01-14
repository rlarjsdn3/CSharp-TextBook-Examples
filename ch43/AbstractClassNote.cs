using System;

// ------------------

public abstract class TableBase
{
    public int Id { get; set; }
    public bool Active { get; set; }
}

public class Children : TableBase
{
    public string Name { get; set; }
}

// ------------------

abstract class GeneralManager
{
    public abstract void SayHumor(); // 메서드 본문 생략
}

class Person : GeneralManager
{
    public override void SayHumor()
    {
        Console.WriteLine("1+1? 노가다!");
    }
}


// ------------------

public abstract class Shape
{
    public abstract double GetArea();
}

public class Square : Shape
{
    private int _size;
    public Square(int size)
    {
        _size = size;
    }

    public override double GetArea()
    {
        return _size * _size;
    }
}



// ------------------


class AbstractClassNote
{
    static void Main()
    {
        // TableBase base = new TableBase();

        var child = new Children() { Id = 1, Active = true, Name = "아이" };
        if (child.Active)
        {
            Console.WriteLine($"{child.Id} - {child.Name}");
        }


        var person = new Person();
        person.SayHumor();


        Square squre = new Square(10);
        Console.WriteLine(squre.GetArea());

        Shape shape = new Square(5);
        Console.WriteLine(shape.GetArea());
    }
}