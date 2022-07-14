using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var truck = new Car();
            truck.Year = 1991;
            truck.Make = "Toyota";
            truck.Model = "Tacoma";
            truck.EngineNoise = "Thunderstorm";
            truck.HonkNoise = "A cat";
            truck.IsDriveable = true;
            Console.WriteLine(truck.Year + " " + truck.Make + " " + truck.Model + " " + truck.EngineNoise + " " + truck.HonkNoise);
            Console.WriteLine(truck.IsDriveable);
            truck.MakeEngineNoise(truck.EngineNoise);
            truck.MakeHonkNoise(truck.HonkNoise);
            

            var sedan = new Car();
            sedan.Year = 2000;
            sedan.Make = "Chevy";
            sedan.Model = "Malibu";
            sedan.EngineNoise = "Four Cylinder";
            sedan.HonkNoise = "Clown Nose";
            sedan.IsDriveable = false;
            Console.WriteLine(sedan.Year + " " + sedan.Make + " " + sedan.Model + " " + sedan.EngineNoise + " " + sedan.HonkNoise);
            Console.WriteLine(sedan.IsDriveable);
            sedan.MakeEngineNoise(sedan.EngineNoise);
            sedan.MakeHonkNoise(sedan.HonkNoise);
            

            var sportCar = new Car();
            sportCar.Year = 2022;
            sportCar.Make = "Porsche";
            sportCar.Model = "Carerra GT";
            sportCar.EngineNoise = "a very well built machine";
            sportCar.HonkNoise = "a regular horn";
            sportCar.IsDriveable = true;
            Console.WriteLine(sportCar.Year + " " + sportCar.Make + " " + sportCar.Model + " " + sportCar.EngineNoise);
            Console.WriteLine(sportCar.HonkNoise + " " + sportCar.IsDriveable);
            sportCar.MakeEngineNoise(sportCar.EngineNoise);
            sportCar.MakeHonkNoise(sportCar.HonkNoise);
            

            var carLot = new List<Car>();
            carLot.Add(truck);
            carLot.Add(sedan);
            carLot.Add(sportCar);

            Console.WriteLine($"Number of cars created : {CarLot.numberOfCars} cars."); //added number of cars currently created.

            foreach(var car in carLot)
            {
                Console.WriteLine($"{truck.Year}, {truck.Make}, {truck.Model}");
                Console.WriteLine($"{sedan.Year}, {sedan.Make}, {sedan.Model}");
                Console.WriteLine($"{sportCar.Year}, {sportCar.Make}, {sportCar.Model}");
                Console.ReadLine();
            }          
        }
    }
}
