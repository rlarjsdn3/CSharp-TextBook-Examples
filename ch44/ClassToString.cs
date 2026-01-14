using System;

namespace ClassToString
{
    class Person
    {
        private string _name;

        public Person(string name)
        {
            this._name = name;
        }

        public override string ToString()
        {
            return $"[Person 클래스 : {this._name}]";
        }
    }

    class ClassToString
    {
        static void Main()
        {
            var person = new Person("김소월");
            Console.WriteLine(person);
        }
    }
}