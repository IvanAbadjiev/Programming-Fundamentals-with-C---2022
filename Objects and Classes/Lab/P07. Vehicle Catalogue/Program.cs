namespace P07._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            //List<Catalog> catalog = new List<Catalog>();
            List <Car> cars = new List<Car>();
            List <Truck> trucks = new List<Truck>();
            while (command != "end")
            {
                string[] data = command.Split("/");
                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int value = int.Parse(data[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, value);
                    cars.Add(newCar);
                    
                }
                else
                {
                    Truck newTruck = new Truck(brand, model, value);
                    trucks.Add(newTruck);
                }


                command = Console.ReadLine();
            }
            Catalog catalog = new Catalog(trucks, cars);


            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }
            foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (var truck in catalog.Trucks
                .OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weigth}kg");
            }


        }
    }

    public class Catalog
    {
        public Catalog(List<Truck> trucks, List<Car> cars)
        {
            Trucks = trucks;
            Cars = cars;
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weigth)
        {
            Brand = brand;
            Model = model;
            Weigth = weigth;
        }

        public string Brand { get; set; }   

        public string Model { get; set; }

        public int Weigth { get; set; }

    }

    public class Car
    {
        public Car(string brand, string model, int hoursePower)
        {
            Brand = brand;
            Model = model;
            HoursePower = hoursePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HoursePower { get; set; }
    }
}
