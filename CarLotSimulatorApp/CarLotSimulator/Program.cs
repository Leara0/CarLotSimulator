using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main()
        {
            var carLot = new CarLot();
            carLot.CarList = new List<Car>();
            
            var car1 = new Car();
            car1.Year = 1999;
            car1.Make = "Honda";
            car1.Model = "Civic";
            car1.EngineNoise = "vroom";
            car1.HonkNoise = "beep";
            car1.IsDrivable = true;
            
            carLot.CarList.Add(car1);
            
            Car.MakeEngineNoise(car1.EngineNoise);
            Car.MakeHonkNoise(car1.HonkNoise);
            

            var car2 = new Car(2024, "Honda", "Accord", "vrrooom", "honk", true);
            Car.MakeEngineNoise(car2.EngineNoise);
            Car.MakeHonkNoise(car2.HonkNoise);
            
            carLot.CarList.Add(car2);

            var car3 = new Car()
            {
                Year = 2020,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "vroom",
                HonkNoise = "beepbeep",
                IsDrivable = true,
            };
            Car.MakeEngineNoise(car3.EngineNoise);
            Car.MakeHonkNoise(car3.HonkNoise);
            
            carLot.CarList.Add(car3);

            for (int i = 0; i < carLot.CarList.Count; i++)
            {
                Console.WriteLine($"Car #{(i+1)}");
                Console.WriteLine($"Year: {carLot.CarList[i].Year}");
                Console.WriteLine($"Make: {carLot.CarList[i].Make}");
                Console.WriteLine($"Model: {carLot.CarList[i].Model}");
                
                
            }

            //TODO

            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}