using System;

class MultiLineString
{
    static void Main()
    {
        string multiline = @"
        ····안녕하세요.
            반갑습니다.\t
            ""좋은 하루 되세요.""
        ";
        Console.WriteLine(multiline);
    }
}