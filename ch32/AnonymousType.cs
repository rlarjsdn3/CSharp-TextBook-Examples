using System;

class AnonymousType
{
    static void Main()
    {
        var hong = new { Name = "홍길동", Age = 21 };
        var park = new { Name = "박문수", Age = 22 };

        Console.WriteLine($"Name : {hong.Name}, Age : {hong.Age}");
        Console.WriteLine($"Name : {park.Name}, Age : {park.Age}");
    }
}