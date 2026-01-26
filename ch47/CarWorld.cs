using System;
using System.Collections;

namespace CarWorld
{
    interface IStandard { 
        void Run(); 
    }

    public class Car : IStandard
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string[] _names;
        private readonly int _length;
        public int Length
        {
            get { return _length; }
        }

        public Car() 
        {
            this._name = "좋은 차";
        }

        public Car(string name)
        {
            _name = name;
        }

        public Car(int length)
        {
            Name = "좋은 차";
            _length = length;
            _names = new string[Length];
        }

        ~Car()
        {
            Console.WriteLine($"{Name} 자동차가 소멸됩니다.");
        }

        public void Run() => Console.WriteLine($"{Name} 자동차가 달립니다.");

        public string this[int index]
        {
            get { return _names[index]; }
            set { _names[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _length; i++)
            {
                yield return _names[i];
            }
        }

        public delegate void EventHandler();

        public event EventHandler? Click;

        public void OnClick()
        {
            Click?.Invoke();
        }
    }

    class CarWorld
    {
        static void Main()
        {
            Car campingCar = new Car("캠핑카");
            campingCar.Run();

            Car sportsCar = new Car();
            sportsCar.Name = "1번 자동차";
            sportsCar.Run();

            Car cars = new Car(2);
            cars[0] = "첫 번째 자동차";
            cars[1] = "두 번째 자동차";
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (string name in cars) 
            {
                Console.WriteLine(name);
            }

            Car btn = new Car("전기 자동차");
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Click += new Car.EventHandler(btn.Run);
            btn.OnClick();
        }
    }
}