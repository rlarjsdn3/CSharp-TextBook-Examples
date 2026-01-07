using System;
using System.Linq;

class MethodChaining
{
    static void Main()
    {
        // 확장 메서드 체이닝
        List<string> names = new List<string> { ".Net", "C#", "TypeScript" };

        var results = names.Where(n => n.Length > 2).OrderBy(n => n);
        foreach (var r in results)
        {
            Console.WriteLine(r);
        }


        // 짝수인 데이터만 오름차순/내림차순 정렬하기
        var numbers = Enumerable.Range(1, 10);
        var filtered = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
        foreach (var f in filtered)
        {
            Console.WriteLine(f);
        }

        filtered = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n);
        foreach (var f in filtered)
        {
            Console.WriteLine(f);
        }


        // 특정 문자열을 포함하는 컬렉션 가져오기
        var colors = new List<string> { "Red", "Green", "Blue" };
        var newColors = colors.Where(c => c.Contains("ee"));
        foreach (var color in newColors)
        {
            Console.WriteLine(color);
        }
    }
}