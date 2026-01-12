using System;

class DelegateDemo
{
    // 함수 생성: 매개변수가 없고 반환값도 없는 함수
    static void Hi() => Console.WriteLine("안녕하세요.");

    // 대리자 생성: 매개변수가 없고 반환값도 없는 함수를 대신 실행할 대리자(함수를 저장할 변수)
    delegate void SayDelegate();

    static void Main()
    {
        SayDelegate say = Hi;
        say();

        var hi = new SayDelegate(Hi);
        hi();
    }
}