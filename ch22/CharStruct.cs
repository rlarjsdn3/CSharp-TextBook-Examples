using System;

class CharStruct
{
    static void Main()
    {
        char a = 'A'; char b = 'a';
        char c = '1'; char d = '\t';

        if (Char.IsUpper(a))
        {
            Console.WriteLine($"{a}은(는) 대문자");
        }

        if (Char.IsLower(b))
        {
            Console.WriteLine($"{b}은(는) 소문자");
        }

        if (Char.IsNumber(c))
        {
            Console.WriteLine($"{c}은(는) 숫자형");
        }

        if (Char.IsWhiteSpace(d))
        {
            Console.WriteLine($"{d}은(는) 공백 문자");
        }

        string s = "abc";
        if (Char.IsLower(s[0]))
        {
            Console.WriteLine("첫 글자가 대문자로 시작합니다.");
        }
        else
        {
            Console.WriteLine("첫 글자가 소문자로 시작합니다.");
        }
        
        Console.WriteLine(Char.MinValue);
        Console.WriteLine(Char.MaxValue);
    }
}