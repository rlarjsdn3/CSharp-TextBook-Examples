using System;
using System.Diagnostics;
using System.Threading;

class StopwatchDemo
{
    static void Main()
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        LognTimeProcess();
        timer.Stop();

        Console.WriteLine("경과 시간 : {0}밀리초", timer.Elapsed.TotalMilliseconds);
        Console.WriteLine("경과 시간 : {0}초", timer.Elapsed.Seconds);
    }

    static void LognTimeProcess()
    {
        Thread.Sleep(3_000);
    }
}