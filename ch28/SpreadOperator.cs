using System;
using System.Collections.Generic;

class SpreadOperator
{
    static void Main()
    {
        int[] first = { 1, 2, 3 };
        int[] second = { 4, 5, 6 };
        int[] combined = [.. first, .. second]; 
        Console.WriteLine("배열 병합 결과 : " + string.Join(", ", combined));

        int[] numbers = [0, .. first, 99];
        Console.WriteLine("배열 요소 추가 결과 : " + string.Join(", ", numbers));

        List<int> list1 = [1, 2, 3];
        List<int> list2 = [4, 5, 6];
        List<int> mergedList = [.. list1, .. list2];
        Console.WriteLine("리스트 병합 결과 : " + string.Join(", ", mergedList));
    }
}