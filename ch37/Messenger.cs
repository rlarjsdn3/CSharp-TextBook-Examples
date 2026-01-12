using System;

public class Messenger
{
    public void PrintMessenger(string message, string prefix = "", string suffix = "")
    {
        Console.WriteLine($"{prefix}{message}{suffix}");
    }
}

public class Program
{
    static void Main()
    {
        var messenger = new Messenger();
        messenger.PrintMessenger("My");
        messenger.PrintMessenger("My", prefix: "Oh");
        messenger.PrintMessenger("My", prefix: "Oh", suffix: "God");
    }
}