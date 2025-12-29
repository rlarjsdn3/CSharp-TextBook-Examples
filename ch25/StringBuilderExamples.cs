using System;
using System.Text;

class StringBuilderExamples
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("January\n");
        sb.Append("February\n");
        sb.AppendLine("March");
        Console.WriteLine(sb.ToString());

        var message = new StringBuilder()
            .AppendFormat("{0} 클래스를 사용한 ", "StringBuilder")
            .Append("메서드 ")
            .Append("체이닝 ")
            .ToString()
            .Trim();
        Console.WriteLine(message);

        StringBuilder sc = new StringBuilder();
        sc.Append("<script>");
        sc.AppendFormat("window.alert(\"{0}\")", DateTime.Now.Year);
        sc.AppendLine("</script>");
        Console.WriteLine(sc.ToString());
    }
}