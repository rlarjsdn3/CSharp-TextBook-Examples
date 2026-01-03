using System;

class ArrayNote
{
    static void Main()
    {
        int[] arr = { 3, 2, 1, 4, 5 };
        
        // Array 클래스의 Sort() 메서드로 배열 정렬하기
        Array.Sort(arr);
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        // Array 클래스의 Reverse() 메서드로 배열을 거꾸로 변환하기
        Array.Reverse(arr);
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        // Array 클래스의 ConvertAll 메서드로 형식 변환하기
        string[] strArr = { "10", "20", "30" };
        int[] intArr = Array.ConvertAll(strArr, Int32.Parse);
        foreach (var item in intArr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}