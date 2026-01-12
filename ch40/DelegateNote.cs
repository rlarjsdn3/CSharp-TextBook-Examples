using System;

class DelegateNote
{
    // 대리자 생성: 매개변수도 반환값도 없는 함수를 담을 수 있는 포인터
    delegate void SayPointer();

    static void Hello() => Console.WriteLine("Hello, Delegate!");

    static void Main()
    {
        // 대리자의 인스턴스 생성 후 매개변수로 대신 실행할 함수 이름 전달
        SayPointer sayPointer = new SayPointer(Hello);

        sayPointer();
        sayPointer.Invoke();
    }
}