using System;

namespace ObjectNote
{
    public class Counter
    {
        public void GetTodayVisitCount()
        {
            Console.WriteLine("오늘 1234명 접속했습니다.");
        }
    }

    class ObjectNote {
        static void Main()
        {
            Counter counter = new Counter();
            counter.GetTodayVisitCount();
        }
    }
}