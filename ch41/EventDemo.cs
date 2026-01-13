using System;

public class MyButton
{
    public delegate void EventHandler();

    public event EventHandler? Click;

    public void OnClick()
    {
        if (Click != null)
        {
            Click?.Invoke();
        }
    }
}

class EventDemo
{
    static void Main()
    {
        MyButton button = new MyButton();
        button.Click += Hi1;
        button.Click += Hi2;

        button.OnClick();
    }

    static void Hi1() => Console.WriteLine("C#");
    static void Hi2() => Console.WriteLine(".NET");
}