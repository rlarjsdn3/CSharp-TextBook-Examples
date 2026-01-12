using System;

namespace AnonymousMethod
{
    public class Print
    {
        public static void Show(string msg) => Console.WriteLine(msg);
    }

    public class AnonymousMethod
    {
        // 대리자 선언
        public delegate void PrintDelegate(string msg);
        public delegate void SumDelegate(int a, int b);
        public delegate int IntParameterAndIntReturnDelegate(int x);

        static void Main()
        {
            // 메서드 직접 호출
            Print.Show("안녕하세요.");

            // 대리자에 메서드 등록 후 호출
            PrintDelegate pd = new PrintDelegate(Print.Show);
            pd("반갑습니다.");

            PrintDelegate am = delegate (string msg)
            {
                Console.WriteLine(msg);
            };
            am("또 만나요.");

            // 익명 메서드 생성 및 호출
            SumDelegate sd = delegate (int a, int b) { Console.WriteLine(a + b); };
            sd.Invoke(3, 5);

            // 대리자에 람다 표현식 등록 후 호출
            IntParameterAndIntReturnDelegate pow = (x) => { return x * x; };
            var r = pow(5);
            Console.WriteLine(r);
        }
    }
}