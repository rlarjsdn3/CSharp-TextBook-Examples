using System;

class Developer
{
    public string Name { get; set; }
}

class PropertyBasics
{
    static void Main()
    {
        var developer = new Developer();
        developer.Name = "김소월";
        Console.WriteLine(developer.Name);
    }
}