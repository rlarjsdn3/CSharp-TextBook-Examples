using System;

class AnonymousDelegate
{
    delegate void SayDelegate();

    static void Main()
    {
        SayDelegate say = delegate()
        {
            Console.WriteLine("반갑습니다.");
        };
        
        say.Invoke();
    }
}