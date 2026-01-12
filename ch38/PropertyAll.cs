using System;
using PropertyAll;

namespace PropertyAll
{
    public class Car
    {
        private string _color;  // 필드

        public Car()
        {
            this._color = "Black";
        }

        // 메서드로 외부에 공개
        public void SetColor(string color)
        {
            this._color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        // 속성
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public string Maker
        {
            get
            {
                return "현대자동차";
            }
        }

        private string _type;
        // 쓰기 전용 속성
        public string Type
        {
            set
            {
                _type = value;
            }
        }
        
        public string Name { get; set; }
    }

    class PropertyAll
    {
        static void Main()
        {
            // Set과 Get 메서드 사용
            Car car1 = new Car();
            car1.SetColor("Red");
            Console.WriteLine(car1.GetColor());

            // 속성을 사용
            Car car2 = new Car();
            car2.Color = "White";
            Console.WriteLine(car2.Color);

            // 읽기 전용 속성 사용
            Car car3 = new Car();
            // car3.Maker = "";
            Console.WriteLine(car3.Maker);

            // 쓰기 전용 속성 사용
            Car car4 = new Car();
            car4.Type = "사륜구동";
            // Console.WriteLine(car4.Type);

            // 축약형 속성
            Car car5 = new Car();
            car5.Name = "제니시스";
            Console.WriteLine(car5.Name);
        }
    }
}