using System;

class ExceptionDemo
{
    static void Main()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 999;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}