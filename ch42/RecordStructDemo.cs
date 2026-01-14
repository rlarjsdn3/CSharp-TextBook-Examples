using System;

// 직원 정보를 나타내는 레코드 클래스
public record class EmployeeClass(string Name, int Age);

// 직원 정보를 나타내는 레코드 구조체
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