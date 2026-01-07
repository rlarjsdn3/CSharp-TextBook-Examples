using System;
using Korea.Seoul;
using In = Korea.Incheon;

namespace Korea
{
    namespace Seoul
    {
        public class Car
        {
            public void Go() => Console.WriteLine("서울 자동차가 달립니다.");
        }
    }

    namespace Incheon
    {
        public class Car
        {
            public void Go() => Console.WriteLine("인천 자동차가 달립니다.");
        }
    }
}

namespace NamespaceDescription
{
    class NamespaceDescription
    {
        static void Main()
        {
            Korea.Seoul.Car s = new Korea.Seoul.Car();
            s.Go();
            Korea.Incheon.Car i = new Korea.Incheon.Car();
            i.Go();

            Car seoul = new Car();
            seoul.Go();
            In.Car incheon = new In.Car();
            incheon.Go();
        }
    }
}