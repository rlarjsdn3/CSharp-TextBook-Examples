using System;

class AnonymousClass
{
    static void Main()
    {
        // 익명 형식으로 객체를 생성하고 속성 3개로 초기화
        var presenter = new { Name = "김소월",  Age = 28, Topic = "C#" };

        Console.WriteLine($"{presenter.Name}, {presenter.Age}, {presenter.Topic}");
    }
}