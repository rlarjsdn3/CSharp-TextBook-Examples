using System;

namespace New
{
    class Parent
    {
        public void Work() => Console.WriteLine("개발자");
    }

    class Child : Parent
    {
        public new void Work() => Console.WriteLine("비개발자");
    }

    class New
    {
        static void Main()
        {
            var child = new Child();
            child.Work();
        }
    }
}