using System;

namespace ConstructorInhertiance
{
    public class Parent
    {
        public string Word { get; set; }
        public Parent(string word)
        {
            Word = word;
        }
    }

    public class Child : Parent
    {
        public Child() : this("[1] 매개변수가 없는 생성자 실행") { }
        
        public Child(string message) : base(message) { }
        public void Say() => Console.WriteLine(base.Word);
    }

    class ConstructorInheritance
    {
        static void Main()
        {
            (new Child()).Say();
            (new Child("[2] 매개변수가 있는 생성자 실행")).Say();
        }
    }
}