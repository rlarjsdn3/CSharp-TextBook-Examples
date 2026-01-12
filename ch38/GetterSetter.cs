using System;

class GetterSetter
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age
    {
        get => (DateTime.Now.Year - BirthDate.Year);
    }

    static void Main()
    {
        GetterSetter user = new GetterSetter();
        user.Name = "마이크로소프트";
        user.BirthDate = new DateTime(1998, 03, 21);

        Console.WriteLine($"{user.Name} 나이 - {user.Age}");
    }
}