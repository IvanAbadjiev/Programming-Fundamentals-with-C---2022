namespace P03._Need_for_Speed_III
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var carsOrMileage = new Dictionary<string, int>();
            var carsOrFuel = new Dictionary<string, int>();
            ReceiveCar(n, carsOrMileage, carsOrFuel);

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string action = cmdArgs[0];

                if (action == "Drive")
                {
                    string car = cmdArgs[1];
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);

                    if (carsOrMileage.ContainsKey(car))
                    {
                        foreach (var kvp in carsOrFuel)
                        {
                            if (kvp.Key == car)
                            {
                                if (kvp.Value >= fuel)
                                {
                                    carsOrFuel[car] = kvp.Value - fuel;
                                    carsOrMileage[car] += distance;
                                    Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                                    if (carsOrMileage[car] >= 100000)
                                    {
                                        Console.WriteLine($"Time to sell the {car}!");
                                        carsOrMileage.Remove(car);
                                        carsOrFuel.Remove(car);
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Not enough fuel to make that ride");
                                    break;
                                }
                            }
                        }
                    }

                }
                else if (action == "Refuel")
                {
                    string car = cmdArgs[1];
                    int fuel = int.Parse(cmdArgs[2]);
                    if (carsOrFuel.ContainsKey(car))
                    {
                        foreach (var kvp in carsOrFuel)
                        {
                            if (kvp.Key == car)
                            {
                                int allFuel = kvp.Value + fuel;

                                if (allFuel < 75)
                                {
                                    carsOrFuel[car] += fuel;
                                    Console.WriteLine($"{car} refueled with {fuel} liters");
                                    break;

                                }
                                else
                                {
                                    int removeFuel = allFuel - 75;
                                    fuel = fuel - removeFuel;
                                    carsOrFuel[car] += fuel;
                                    Console.WriteLine($"{car} refueled with {fuel} liters");
                                    break;
                                }
                            }
                        }
                    }


                }
                else if (action == "Revert")
                {
                    string car = cmdArgs[1];
                    int kilometers = int.Parse(cmdArgs[2]);

                    foreach (var kvp in carsOrMileage)
                    {
                        if (kvp.Key == car)
                        {
                            if (kvp.Value > 10000)
                            {
                                carsOrMileage[car] = kvp.Value - kilometers;
                                int afterRevert = carsOrMileage[car];
                                if (afterRevert <= 10000)
                                {
                                    carsOrMileage[car] = 10000;
                                    break;
                                }
                                else
                                {

                                    Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                                    break;
                                }
                            }



                        }

                    }

                }

                //"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."



            }

            foreach (var kvp in carsOrMileage)
            {
                Console.WriteLine($"{kvp.Key} -> Mileage: {kvp.Value} kms, Fuel in the tank: {carsOrFuel[kvp.Key]} lt.");
            }


        }

        static void ReceiveCar(int n, Dictionary<string, int> carsOrMileage, Dictionary<string, int> carsOrFuel)
        {
            for (int i = 0; i < n; i++)
            {
                string[] currCar = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string car = currCar[0];
                int mileage = int.Parse(currCar[1]);
                int fuel = int.Parse(currCar[2]);

                carsOrMileage.Add(car, mileage);
                carsOrFuel.Add(car, fuel);
            }
        }
    }
}
