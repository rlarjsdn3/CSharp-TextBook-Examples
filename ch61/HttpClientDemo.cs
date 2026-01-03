using System;
using System.Net.Http;
using System.Threading.Tasks;

class HttpClientDemo
{
    static async Task Main()
    {
        // HttpClient 객체 생성
        var httpClient = new HttpClient();

        // GetAsync() 메서드 호출
        var httpResponseMessage = await httpClient.GetAsync("http://www.microsoft.com");

        // HTML 읽어오기
        var responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

        // 출력
        Console.WriteLine(responseBody);
    }
}