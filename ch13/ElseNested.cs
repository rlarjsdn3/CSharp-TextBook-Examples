using System;

class ElseNested
{
    static void Main()
    {
        Console.Write("문자를 입력하세요. (y/n/c) : ");
        char input = Convert.ToChar(Console.ReadLine());
        if (input == 'y')
        {
            Console.WriteLine("Yes");
        } 
        else
        {
            if (input == 'n')
            {
                Console.WriteLine("No");
            } 
            else
            {
                Console.WriteLine("Cancel");
            }
        }
    }
}