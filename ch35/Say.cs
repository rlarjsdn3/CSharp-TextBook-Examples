using System;

class Say
{
    private string message = "[1] 안녕하세요.";
    public Say() => Console.WriteLine(this.message);

    public Say(string message) : this()
    {
        this.message = message;
        Console.WriteLine(this.message);
    }
}

class Program
{
    static void Main()
    {
        new Say("[2] 잘가요.");
    }
}