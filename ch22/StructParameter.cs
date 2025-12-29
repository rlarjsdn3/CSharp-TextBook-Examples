using System;

struct Member
{
    public string Name;
    public int Age;
}

class StructParameter
{
    static void Main()
    {
        string name = "홍길동"; 
        int age = 21;
        Print(name, age);

        Member m;
        // m = new Member();
        m.Name = "백두산";
        m.Age = 100;
        Print(m);
    }

    static void Print(string name, int age) 
        => Console.WriteLine($"이름 : {name}, 나이 : {age}");

    static void Print(Member member) 
        => Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
}