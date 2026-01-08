using System;

public class TestClass
{
    private static string name = "홍길동";
    public static string siteName = "길벗";

    public static string GetName()
    {
        return name;
    }
}

class PublicPrivate
{
    static void Main()
    {
        // TestClass.name;
        Console.WriteLine(TestClass.siteName);

        Console.WriteLine(TestClass.GetName()); 
    }
}