using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class ObjectIntializer
{
    static void Main()
    {
        // 속성 사용
        Person p1 = new Person();
        p1.Name = "백두산";
        p1.Age = 100;

        // 생성자 사용
        Person p2 = new Person("백두산", 100);

        // 개체 이니셜라이저 사용
        Person p3 = new Person { Name = "백두산", Age = 100 };
        Console.WriteLine($"{p3.Name} - {p3.Age}");
    }
}