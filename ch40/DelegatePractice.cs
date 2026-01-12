using System;
using System.Security.Cryptography.X509Certificates;

namespace DelegatePractice
{
    public class CarDriver
    {
        public static void GoForward() => Console.WriteLine("직진");
        public static void GoLeft() => Console.WriteLine("좌회전");
        public static void GoRight() => Console.WriteLine("우회전");
    }

    public class Insa
    {
        public void Bye() => Console.WriteLine("안녕히 가세요.");
    }

    public delegate void GoHome();

    public class DelegatePractice
    {
        public delegate void Say();

        private static void Hello() { Console.WriteLine("Hello"); }

        private static void Hi() { Console.WriteLine("Hi"); }

        static void Main(string[] args)
        {
            // 메서드를 따로따로 호출
            CarDriver.GoLeft();
            CarDriver.GoForward();
            CarDriver.GoRight();

            // 대리자를 사용한 메서드 등록 및 호출
            GoHome go = new GoHome(CarDriver.GoLeft);
            go += CarDriver.GoForward;
            go += CarDriver.GoRight;
            go += CarDriver.GoLeft;
            go += CarDriver.GoLeft;
            go();

            Console.WriteLine();

            // 대리자를 사용하여 한 번에 메서드 2개 호출
            Say say;
            say = new Say(Hi);
            say += new Say(Hello);
            say();

            // 대리자를 사용하여 호출
            Insa insa = new Insa();
            Say say2 = new Say(insa.Bye);
            say2 += new Say(insa.Bye);
            say2();
        }
    }
}