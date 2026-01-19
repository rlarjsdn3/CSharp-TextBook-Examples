using System.Runtime.CompilerServices;
using static System.Console;

class CallerInformation
{
    static void Main()
    {
        TraceMessage("여기에서 무엇인가 실행...");
    }

    public static void TraceMessage(
        string message,
        [CallerMemberName] string memeberName = "",
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    { 
        WriteLine("실행 내용 : " + message); 
        WriteLine("멤버 이름 : " + memeberName);
        WriteLine("소스 경로 : " + filePath);
        WriteLine("실행 라인 : " + lineNumber);
    }
}