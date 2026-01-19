using System;
using System.Reflection;

namespace ReflectionGetMethod
{
    public class MemberClass
    {
        public string Name { get; set; } = "길벗출판사";
        public string GetName()
        {
            return Name + ", " + DateTime.Now.ToShortTimeString();
        }
    }

    class ReflectionGetMethod
    {
        static void Main()
        {
            MemberClass m = new MemberClass();
            Type t = m.GetType();

            PropertyInfo pi = t.GetProperty("Name");
            Console.WriteLine("속성 호출 : " + pi.GetValue(m));

            MethodInfo mi = t.GetMethod("GetName");
            Console.WriteLine("메서드 호출 : " + mi.Invoke(m, null));

            // dynamic 객체로 쉽게 멤버를 동적으로 호출
            dynamic d = new MemberClass();
            Console.WriteLine("속성 호출 : " + d.Name);
            Console.WriteLine("메서드 호출 : " + d.GetName());
        }
    }
}