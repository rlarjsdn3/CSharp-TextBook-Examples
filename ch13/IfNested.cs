using System;

class IfNested
{
    static void Main()
    {
        string name = "C#";
        int version = 14;

        if (name == "C#")
        {
            if (version == 14)
            {
                Console.WriteLine($"{name} {version}");
            }
        }
    }
}