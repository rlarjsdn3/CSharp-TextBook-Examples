using System;

namespace OverridingDemo
{
    public class Parent
    {
        public void Say() => Console.WriteLine("부모_안녕하세요.");
        public void Run() => Console.WriteLine("부모_달리다.");
        public virtual void Walk() => Console.WriteLine("부모_걷다.");
    }

    public class Child : Parent
    {
        // 이름만 같은 메서드를 새로 정의함 (부모 메서드를 암묵적으로 숨김, 다형성 없음)
        public void Say() => Console.WriteLine("자식_안녕하세요.");

        // 부모 메서드를 의도적으로 숨김(new), 다형성 없음
        public new void Run() => Console.WriteLine("자식_달리다.");

        // 부모 virtual 메서드를 재정의(override), 다형성 발생
        public override void Walk() => Console.WriteLine("자식_걷다.");
    }

    class OverridingDemo
    {
        static void Main()
        {
            Parent p = new Child();
            p.Say();
            p.Run();
            p.Walk();

            Child c = new Child();
            c.Say();
            c.Run();
            c.Walk();
        }
    }
}