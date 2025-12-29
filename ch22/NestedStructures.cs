using System;

namespace NestedStructures
{
    struct Address
    {
        public string Street;
        public string City;
        public string ZipCode;
    }

    struct Student
    {
        public string Name;
        public Address Address;
    }

    class Program
    {
        static void Main()
        {
            Student student1 = new Student();
            student1.Name = "철수";
            student1.Address = new Address
            {
                Street = "조암남로 132길", City = "대구광역시", ZipCode = "42759"
            };

            Console.WriteLine("이름 : " + student1.Name);
            Console.WriteLine("주소 : ");
            Console.WriteLine("  - 거리 : " + student1.Address.Street);
            Console.WriteLine("  - 도시 : " + student1.Address.City);
            Console.WriteLine("  - 우편번호 : " + student1.Address.City);
            
        }
    }


}