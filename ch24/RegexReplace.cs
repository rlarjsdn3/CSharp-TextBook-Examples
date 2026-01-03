using System;
using System.Text.RegularExpressions;

class RegexReplace
{
    static void Main()
    {
        string s = "안녕하세요.    반갑습니다.    또 만나요.";
        var regex = new Regex("\\s+");
        string r = regex.Replace(s, " ");
        Console.WriteLine(s);
        Console.WriteLine(r);
    }
}