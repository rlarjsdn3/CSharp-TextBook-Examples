using System;

/// <summary>
/// 지정된 제목을 콘솔에 출력한 뒤, 전달된 동작을 실행합니다.
/// 예제 실행 전후의 구분선을 출력하는 용도로 사용됩니다.
/// </summary>
/// <param name="title">
/// 콘솔에 표시할 예제 제목입니다.
/// </param>
/// <param name="action">
/// 제목 출력 후 실행할 동작을 나타내는 대리자입니다.
/// </param>
void Example(string title, Action action)
{
    Console.WriteLine("--------- {0} ---------", title);
    action();
}