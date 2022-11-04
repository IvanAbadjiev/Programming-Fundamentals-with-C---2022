namespace P06._Vehicle_Catalogue
{
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    internal class Program
    {
        static void Main(string[] args)
        {

            List<CarCataloge> carCataloge = new List<CarCataloge>();

            AddCarsToCataloge(carCataloge);

            SelectAndPrintCar(carCataloge);
            
            
           
        }
        static void AddCarsToCataloge(List<CarCataloge> carCataloge)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArds = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = cmdArds[0];
                string model = cmdArds[1];
                string color = cmdArds[2];
                int horsePower = int.Parse(cmdArds[3]);
                CarCataloge car = new CarCataloge(type, model, color, horsePower);
                carCataloge.Add(car);

            }
        }
        static void SelectAndPrintCar(List<CarCataloge> carCataloge)
        {
            string command;

            int carTotalPower = 0;
            double carCount = 0;

            int truckTotalPower = 0;
            double truckCount = 0;

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {

                foreach (CarCataloge car in carCataloge.Where(x => x.Model == command))
                {
                    if (car.Type == "car")
                    {
                        Console.WriteLine(
                        $"Type: Car{Environment.NewLine}" +
                        $"Model: {car.Model}{Environment.NewLine}" +
                        $"Color: {car.Color}{Environment.NewLine}" +
                        $"Horsepower: {car.HorsePower:f0}");
                    }
                    else if (car.Type == "truck")
                    {
                        Console.WriteLine(
                        $"Type: Truck{Environment.NewLine}" +
                        $"Model: {car.Model}{Environment.NewLine}" +
                        $"Color: {car.Color}{Environment.NewLine}" +
                        $"Horsepower: {car.HorsePower:f0}");
                    }

                    
                }

            }

            foreach (CarCataloge car in carCataloge)
            {
                if (car.Type == "car")
                {
                    carCount++;
                    carTotalPower += car.HorsePower;
                }
                else if (car.Type == "truck")
                {
                    truckCount++;
                    truckTotalPower += car.HorsePower;
                }
            }
            if (carCount == 0)
            {

                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {truckTotalPower / truckCount:f2}.");

            }
            else if (truckCount == 0)
            {
            Console.WriteLine($"Cars have average horsepower of: {carTotalPower / carCount:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            else if (truckCount == 0 && carCount == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {carTotalPower / carCount:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {truckTotalPower / truckCount:f2}.");
            }

        }
    }
    public class CarCataloge
    {
        public CarCataloge(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; private set; }
        public string Model { get; private set; }
        public string Color  { get; private set; }
        public int HorsePower { get; private set; }
    }

}
