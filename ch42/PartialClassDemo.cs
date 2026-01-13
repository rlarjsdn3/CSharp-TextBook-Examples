using System;

namespace PartialClassDemo
{
    public partial class Hello
    {
        public void Bye() => Console.WriteLine("FirstDeveloper.cs");
    }
}

namespace PartialClassDemo
{
    public partial class Hello
    {
        public void Hi() => Console.WriteLine("SecondDeveloper.cs");
    }
}

namespace PartialClassDemo
{
    class PartialClassDemo
    {
        static void Main()
        {
            var hello = new Hello(); 
            hello.Hi();
            hello.Bye();
        }
    }
}