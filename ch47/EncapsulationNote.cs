using System;

namespace EncapsulationNote
{
    public class Person
    {
        private string _name;
        public void SetName(string name) => _name = name;
        public string GetName() => _name;
    }

    class EncapsulationNote
    {
        static void Main()
        {
            var person = new Person();
            person.SetName("Alice");
            Console.WriteLine(person.GetName());
        }
    }
}