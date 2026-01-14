using System;

namespace InheritanceDemo
{
    class Parent
    {
        public void Foo() => Console.WriteLine("부모 클래스의 멤버 호출");
    }

    class Child : Parent
    {
        public void Bar() => Console.WriteLine("자식 클래스의 멤버 호출");
    }

    class InheritanceDemo
    {
        static void Main()
        {
            // 자식 클래스의 인스턴스 생성
            Child child = new Child();
            child.Foo();
            child.Bar();
        }
    }
}