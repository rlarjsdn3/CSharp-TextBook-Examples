using System.Collections.Generic;
using static System.Console;

namespace NullWithObject
{
    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    class Address
    {
        public string Street { get; set; }
    }

    class NullWithObject
    {
        static void Main()
        {
            var people = new Person[]
            {
                new Person { Name = "RedPlus" },
                null
            };

            foreach (var person in people)
            {
                WriteLine($"{person?.Name ?? "아무개"}은(는)" +
                          $"{person?.Address?.Street ?? "아무곳"}에 삽니다.");
            }

            var otherPeople = null as Person[];

            WriteLine($"첫 번째 사람 : {otherPeople?[0]?.Name ?? "없음"}");
        }
    }
}