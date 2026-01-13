using System;

public record class EmployeeClass(string Name, int Age);

public record struct EmployeeStruct(string Name, int Age);

class RecordStructDemo
{
    static void Main()
    {
        var employee1 = new EmployeeClass("홍길동", 21);

        var employee2 = employee1 with { Age = 30 };

        Console.WriteLine(employee2);
    }
}