using System;

namespace PropertyNote
{
    public class Car
    {
        // public 필드로 속성처럼 사용 (원칙은 private)
        public static string Color;

        // 언더스코어(_) 문자로 속성에 대한 필드 이름 정의
        private static string _type;

        // public한 속성 정의: 읽고 쓰기 가능한 속성
        public static string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        static Car()
        {
            Color = "Red";
            _type = "스포츠카";
        }
    }

    public class Person
    {
        private int _birthYear;

        // 쓰기 전용: 계산식 사용
        public int BirthYear
        {
            set
            {
                if (value >= 1900)
                {
                    _birthYear = value;
                } 
                else
                {
                    _birthYear = 0;
                }
            }
        }

        public string Name { get; set; }

        // 읽기 전용: 계산식 사용
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - _birthYear);
            }
        }

        public Person(string name)
        {
            Name = name;
        }
    }

    class PropertyNote
    {
        static void Main()
        {
            Car.Color = "Black";
            Car.Type = "세단";
            Console.WriteLine($"차종 : {Car.Type}, 색상 : {Car.Color}");

            Person person = new Person("김소월 ");
            person.BirthYear = (DateTime.Now.Year - 21);
            Console.WriteLine($"이름 : {person.Name}, 나이 : {person.Age}");
        }
    }
}