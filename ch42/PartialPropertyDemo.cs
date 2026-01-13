using System;

public partial class EmployeePartial
{
    public partial string FullName { get; set; } // 선언
}

public partial class EmployeePartial
{
    private string _fullName = ""; // setter의 value가 null일 수 있기에 초기값 명시 
    public partial string FullName // 구현
    {
        get => _fullName;
        set => _fullName = value.ToUpper();
        // set => _fullName = value?.ToUpper() ?? "";
    }
}

class PartialPropertyDemo
{
    static void Main()
    {
        EmployeePartial employee = new EmployeePartial()
        {
            FullName = "john doe"
        };
        Console.WriteLine(employee.FullName);
    }
}