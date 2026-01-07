using System;

class NullDemo
{
    static void Main()
    {
        // null 값 사용하기
        int i = 0;
        string s = null;
        s = "안녕하세요";
        string empty = "";
        Console.WriteLine(i);
        Console.WriteLine(s);
        Console.WriteLine(empty);

        // null 가능 형식 사용하기
        string? nullableString = null;
        Console.WriteLine(nullableString);

        int? nullableInteger = null;
        Console.WriteLine(nullableInteger);

        double? nullableDouble = null;
        Console.WriteLine(nullableDouble);

        Nullable<int> ii = null;
        int? iii = null;
        Nullable<double> dd = null;
        double? ddd = null;


        // ?? 연산자 (null 병합 연산자)
        string? nullValue = null;
        string message = "";

        if (nullValue == null)
        {
            message = "[1] null이면 새로운 값으로 초기화합니다.";
        }
        Console.WriteLine(message);

        message = nullValue ?? "[2] null]이면 새로운 값으로 초기화합니다.";
        Console.WriteLine(message);

        nullValue = "Hello";
        message = nullValue ?? "[3] Nothing";
        Console.WriteLine(message);


        // null 병합 연산자로 문자열 변수의 null 값 확인하기
        var result = "";
        var msg = "";

        msg = null;
        result = msg ?? "기본값";
        Console.WriteLine(result);

        msg = "있는 값";
        result = msg ?? "기본값";
        Console.WriteLine(msg);


        // null 가능 형식에 null 병합 연산자 사용하기
        int? value = null;
        int defaultValue = value ?? -1;
        Console.WriteLine(defaultValue);


        // null 병합 연산자와 default 키워드
        int? x = null;
        int y = x ?? 100;
        int z = x ?? default(int);
        z = x ?? default;
        Console.WriteLine($"y : {y}, z : {z}");


        // null 병합 연산자와 null 가능 형식을 함께 사용하기
        bool? unknown = null;
        if (unknown ?? true)
            Console.WriteLine("출력됨");

        unknown = false;
        if (!unknown ?? false)
            Console.WriteLine("출력됨");


        // null 조건부 연산자 사용하기
        int? len;
        string msg2;

        msg2 = null;
        len = msg2?.Length;
        Console.WriteLine(len);

        msg2 = "안녕하세요";
        len = msg2.Length;
        Console.WriteLine(len);


        // null 조건부 연산자와 컬렉션 클래스
        List<string> list = null;
        int? numberOfList;

        numberOfList = list?.Count;
        Console.WriteLine(numberOfList);

        list = new List<string>();
        list.Add("안녕하세요.");
        list.Add("반갑습니다.");
        numberOfList = list.Count;
        Console.WriteLine(numberOfList);


        // null 조건부 연산자와 null 병합 연산자 함께 사용하기
        int num;
        List<string> strList;

        strList = null;
        num = strList?.Count ?? 0;
        Console.WriteLine(num);

        strList = new List<string>();
        strList.Add("또 만나요.");
        num = strList?.Count ?? 0;
        Console.WriteLine(num);
    }
}