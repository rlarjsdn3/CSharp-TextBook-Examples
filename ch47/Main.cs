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