using System;

record Subscriber(string Name, int Duration, bool IsAvailable);

class RecordDemo
{
    static void Main()
    {
        var subscriber = new Subscriber("김소월", 222, true);

        // 새로운 이름을 가진 객체 생성
        var vip = subscriber with { Name = "김건우" };

        var (name, duration, isAvailable) = vip;

        Console.WriteLine($"{name} - {duration} - {isAvailable}");
    }
}