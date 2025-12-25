using System;

class Car
{
    private string brand; 
    
    public string GetBrand()
    {
        return brand;
    }

    public Car()
    {
        brand = "Toyota";
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();

        Console.WriteLine(myCar.GetBrand());
    }
}