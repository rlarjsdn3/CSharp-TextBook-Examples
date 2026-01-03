using System;
using System.Collections;

class ArrayListNote
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("C#");
        list.Add("Typescript");

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i].ToString());
        }
    }
}