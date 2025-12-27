    static void Main()
    {
        string[] authors = { };
        if (authors.Length > 0)
        {
            Console.Write($"저자가 {authors.Length}명 있습니다.");
        }
        else
        {
            Console.Write("저자가 아무도 없습니다.");
        }
    }