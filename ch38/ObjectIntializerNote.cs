using System;

namespace ObjectIntializerNote
{
    public class Person
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Age { get; set; }

        public string Type { get; set; } = "사람";
    }

    class ObjectIntializerNote
    {
        static void Main()
        {
            // 생성자로 인스턴스 생성
            Person p1 = new Person();
            p1.Name = "홍길동";
            p1.Age = 21;
            Console.WriteLine($"이름 : {p1.Name}, 나이 : {p1.Age}");
            
            // 개체 이니셜라이저로 인스턴스 생성
            Person p2 = new Person { Name = "백두산", Age = 21 };
            Console.WriteLine($"이름 : {p2.Name}, 나이 : {p2.Age}");


        }
    }
}