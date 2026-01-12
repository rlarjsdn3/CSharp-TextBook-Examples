using System;
using static System.Console;

public class PersonInit
{
    public string? Name { get; init; } // Name은 객체를 초기화할 때만 설정 가능
    public int Age { get; init; } // Age는 객체를 초기화할 때만 설정 가능
    public string Address { get; set; } // Address는 객체 생성 후에도 설정 가능
}

class InitDemo
{
    static void Main()
    {
        var person = new PersonInit { Name = "김소월", Age = 21, Address = "용산구" };
        WriteLine($"이름 : {person.Name}, 나이 : {person.Age}, 주소: {person.Address}");

        person.Address = "부산";
        WriteLine($"변경된 주소 : {person.Address}");

        // person.Age = 25;
    }
}