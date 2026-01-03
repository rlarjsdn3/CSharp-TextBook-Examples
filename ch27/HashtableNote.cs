using System;
using System.Collections;

class HashtableNote
{
    static void Main()
    {
        Hashtable hash = new Hashtable();

        hash[0] = "닷넷코리아";
        hash["닉네임"] = "레드플러스";
        hash["사이트"] = "비주얼아카데미";

        Console.WriteLine(hash[0]);
        Console.WriteLine(hash["닉네임"]);
        Console.WriteLine(hash["사이트"]);

        Console.WriteLine(hash["none"]);

        foreach (object o in hash.Keys)
        {
            Console.WriteLine(hash[o]);
        }
    }
}