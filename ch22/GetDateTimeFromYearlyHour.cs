using System;

class GetDateTimeFromYearlyHour
{
    static void Main()
    {
        Console.WriteLine(GetDateTimeFromYearlyHourNumber(1));
        Console.WriteLine(GetDateTimeFromYearlyHourNumber(8760/2));
        Console.WriteLine(GetDateTimeFromYearlyHourNumber(8760));
    }

    static DateTime GetDateTimeFromYearlyHourNumber(int hours)
    {
        return (new DateTime(2025, 1, 1, 0, 0, 0)).AddHours(--hours);
    }
}