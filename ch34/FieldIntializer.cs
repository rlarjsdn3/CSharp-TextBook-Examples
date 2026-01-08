using System;

class Say
{
    private string message = "안녕하세요.";

    public void Hi()
    {
        this.message = "반갑습니다.";
        Console.WriteLine(this.message);
    }
}

class FieldIntializer
{
    static void Main()
    {
        Say say = new Say();
        say.Hi();
    }
}