using System;

class TryCatch
{
    static void Main()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 999;
        } catch
        {
            Console.WriteLine("에러가 발생했습니다.");
        }
    }
}