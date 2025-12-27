using System;

class FunctionAddNumbers
{
    /// <summary>
    /// 두 수를 더해 그 결과값을 반환시켜 주는 함수
    /// </summary>
    /// <param name="a">첫 번째 매개변수</param>
    /// <param name="b">두 번째 매개변수</param>
    /// <returns>a와 b를 더한 값</returns>
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int a = 3;
        int b = 5;
        int c = AddNumbers(a, b);
        Console.WriteLine($"{a} + {b} = {c}");
    }
}