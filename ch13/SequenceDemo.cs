using System;

class SequenceDemo
{
    static void Main()
    {
        int kor = 100;
        int eng = 90;

        int total = 0;
        double avg = 0.0;

        total = kor + eng;
        avg = total / 2.0d;

        Console.WriteLine("총점: {0}", total);
        Console.WriteLine("평균: {0}", avg);
    }
}