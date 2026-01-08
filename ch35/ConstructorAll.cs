using System;
using ConstructorAll;

namespace ConstructorAll
{
    public class Person
    {
        private static readonly string _Name;
        private int _Age;
        static Person() { _Name = "홍길동"; } // 정적 생성자
        public Person() { _Age = 21; } // 인스턴스 생성자
        public Person(int age) { _Age = age; }

        public static void Show()
        {
            Console.WriteLine("이름 : {0}", _Name);
        }

        public void Print()
        {
            Console.WriteLine("나이 : {0}", _Age);
        }
    }
}

class ConstructAll
{
    static void Main()
    {
        Person.Show();

        (new Person()).Print();
        (new Person(22)).Print();
    }
}