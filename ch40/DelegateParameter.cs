using System;

class DelegateParameter
{
    delegate void Runner();

    static void Main()
    {
        RunnerCall(new Runner(Go));
        RunnerCall(new Runner(Back));
        RunnerCall(new Runner(() => { Console.WriteLine("안녕하세요!"); }));
    }

    static void RunnerCall(Runner runner) => runner();
    static void Go() => Console.WriteLine("직진");
    static void Back() => Console.WriteLine("후진");
}