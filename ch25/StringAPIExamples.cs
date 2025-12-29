using System;
using System.Security.Cryptography.X509Certificates;

class StringAPIExamples
{
    static void Main()
    {
        // 문자열 관련 주요 메서드 다루기
        string message = "hello, world!";
        Console.WriteLine(message.ToUpper());
        Console.WriteLine(message.ToLower());
        Console.WriteLine(
            message.Replace("hello", "안녕하세요").Replace("world", "세계")
        );

        // 메서드 체이닝
        Console.WriteLine(
            " Hello ".Replace("Hello", "Hi").TrimStart().TrimEnd().Trim()
        );

        // String 클래스
        String s1 = "안녕하세요.";
        string s2 = "반갑습니다!";
        Console.WriteLine($"{s1} {s2}");

        char[] charArray = { 'A', 'B', 'C' };
        string str = new string(charArray);
        Console.WriteLine(str);

        // Length 속성을 사용하여 문자열 길이 구하기
        string s3 = "Hello.";
        string s4 = "안녕하세요.";
        Console.WriteLine($"{s3.Length}, {s4.Length}");

        // String.Concat() 메서드를 사용하여 문자열 연결하기
        string s5 = String.Concat("반갑", "습니다.");
        Console.WriteLine(s5);

        // 문자열을 묶는 세 가지 표현 방법 정리하기
        var displayName = "";
        var firstName = "길동";
        var lastName = "홍";

        displayName = "이름 : " + lastName + firstName;
        Console.WriteLine(displayName);

        displayName = String.Format("이름 : {0}{1}", lastName, firstName);
        Console.WriteLine(displayName);

        displayName = $"이름 : {lastName}{firstName}";
        Console.WriteLine(displayName);

        // 문자열을 비교하는 두 가지 방법 정리하기
        string userName = "RedPlus";
        string userNameInput = "redPlus";

        if (userName.ToLower() == userNameInput.ToLower())
        {
            Console.WriteLine("[1] 같습니다.");
        }
        if (String.Equals(userName, userNameInput, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("[2] 같습니다.");
        }

        // 문자열 대소문자 비교하기
        string s6 = "Gilbut";
        string s7 = "gilbut";

        if (s6 == s7)
        {
            Console.WriteLine("같다.");
        } 
        else
        {
            Console.WriteLine("다르다.");
        }

        if (s6.Equals(s7, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("같다.");
        }

        // ToCharArry() 메서드로 문자열을 문자 배열로 변환하기
        string s = "Hello.";
        char[] ch = s.ToCharArray();

        for (int i = 0; i < ch.Length; i++)
        {
            Console.Write($"{ch[i]}\t");
        }
        Console.WriteLine();

        // Split() 메서드로 문자열 분리하기
        string src = "Red,Green,Blue";
        string[] colors = src.Split(',');
        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

        // 문자열의 null 값 및 빈 값 체크하기
        var emptyStr = String.Empty;

        if (emptyStr == null || emptyStr == "")
        {
            Console.WriteLine("emptyStr 변수 값은 null 또는 빈 값입니다.");
        }

        if (String.IsNullOrEmpty(emptyStr))
        {
            Console.WriteLine("emptyStr 변수 값은 null 또는 빈 값입니다.");
        }

        // 문자열 변수의 유효성을 검사하는 세 가지 방법
        string abc = "a_b_c";

        abc = null;
        if (abc != "" && abc != null)
        {
            var s0 = userName.Split('_');
        }

        abc = "";
        if (!string.IsNullOrEmpty(abc))
        {
            var s0 = userName.Split('_');
        }

        abc = " ";
        if (!string.IsNullOrWhiteSpace(abc))
        {
            var s0 = userName.Split('_');
        }


        // 문자열 처리 관련 주요 API 살펴보기
        string emptyString = "";
        emptyString = String.Empty;

        string def = "Abc Def Fed Cba";
        Console.WriteLine(def.Length);
        Console.WriteLine(def[6 - 1]);
        Console.WriteLine(def.ToUpper());
        Console.WriteLine(def.ToLower());
        Console.WriteLine(def.Trim());
        Console.WriteLine(def.TrimStart());
        Console.WriteLine(def.TrimEnd());
        Console.WriteLine(def.Replace("Def", "디이에프"));
        Console.WriteLine(def.IndexOf('e'));
        Console.WriteLine(def.LastIndexOf('e'));
        Console.WriteLine(def.Substring(5, 3));
        Console.WriteLine(def.Substring(5));
        Console.WriteLine(def.Remove(5, 3));
        Console.WriteLine(def[2-1] == def[14-1]);
        Console.WriteLine(String.Compare("A", "C"));
        Console.WriteLine("A".CompareTo("B"));
        Console.WriteLine("ABC".Equals("ABC"));
        Console.WriteLine("ABC".Equals("ABC"));
        Console.WriteLine(String.Equals("ABC", "ABC"));
        Console.WriteLine("http://www.apple.com/kr".StartsWith("http"));
        Console.WriteLine("http://www.apple.com/kr".EndsWith("http"));

        string hi1 = "안녕";
        string hi2 = "하세요";

        Console.WriteLine(String.Concat(hi1, hi2));
        Console.WriteLine(String.Format("{0} {1} {0}", hi1, hi2));

        Console.WriteLine(String.Format("{0:C}", 1000));
        Console.WriteLine(String.Format("{0:#,###}", 1000));

        string[] defArray = def.Split(' ');
        foreach (string sa in defArray)
        {
            Console.WriteLine(sa); 
        }

        string original = "Hello";
        string modified = original.Insert(5, "World");
        Console.WriteLine(modified);
        
        modified = original.Remove(5);
        Console.WriteLine(modified);

        string number = "1234";
        Console.WriteLine(number.PadLeft(10, '0'));
        Console.WriteLine(number.PadRight(10, '_'));

    }
}