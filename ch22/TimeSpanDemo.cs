using System;

class TimeSpanDemo
{
    static void Main()
    {
        TimeSpan dday = Convert.ToDateTime("2025-12-25") - DateTime.Now;
        Console.WriteLine($"{DateTime.Now.Year}년도 크리스마스는 {(int)dday.TotalDays}일 남음");

        TimeSpan times = DateTime.Now - Convert.ToDateTime("1998-03-21");
        Console.WriteLine($"지금까지 며칠 살아왔는지? {(int)times.TotalDays}일");

        Console.WriteLine($"2025년 1월 1일부터 {(int)(DateTime.Now - (new DateTime(2025, 1, 1))).TotalDays}일 지났습니다.");
    }
}