using System;

class Employee(string name, int age)
{
    private readonly string _name = name;
    private readonly int _age = age;

    public void Display()
        => Console.WriteLine($"이름 : {_name}, 나이 : {_age}");
}

class PrimaryConstructor
{
    static void Main()
    {
        Employee employee = new Employee("홍길동", 21);
        employee.Display();
    }
}