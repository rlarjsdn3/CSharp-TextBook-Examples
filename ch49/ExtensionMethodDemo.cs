using System;

namespace ExtensionMethodDemo
{
    public static class MyClass
    {
        public static int WordCount(this string value)
        {
            return value
                .Split(new char[] { ' ', '.', '?' }, 
                    StringSplitOptions.RemoveEmptyEntries)
                .Length;
        }

        static void Main()
        {
            string s = "안녕하세요? 확장메서드... ...";
            Console.WriteLine(s.Length);
            Console.WriteLine(s.WordCount());
        }
    }
}