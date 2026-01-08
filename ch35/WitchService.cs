using System;

public class WitchService
{
    private readonly string _serviceName; // 읽기 전용 필드
    public WitchService(string serviceName)
    {
        _serviceName = serviceName;
    }
    public void Run() => Console.WriteLine($"{_serviceName} 기능을 실행합니다.");
}

class Program
{
    static void Main()
    {
        var file = new WitchService("[1] 파일 로그");
        file.Run();

        var db = new WitchService("[2] DB 로그");
        db.Run();
    }
}