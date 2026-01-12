using System;

class Person
{
    private string _name; // 필드(field)
    
    public string Name // 속성(property)
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
}

class FullProperty
{
    static void Main()
    {
        var person = new Person();
        person.Name = "Gilbut";
        Console.WriteLine(person.Name); 
    }
}