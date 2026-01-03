using System.Diagnostics;

namespace DotNet
{
    class ProcessStartDemo
    {
        static void Main()
        {
            Process.Start("Notepad.exe");
            Process.Start("Explorer.exe", "https://dotnetkorea.com");
        }
    }
}