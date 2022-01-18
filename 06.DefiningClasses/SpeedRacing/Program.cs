using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);

                cars.Add(car);

            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string model = command[1];
                double travelDistance = double.Parse(command[2]);

                cars.Where(c => c.Model == model)
                    .ToList().ForEach(c => c.Calculation(travelDistance));

                command = Console.ReadLine().Split();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
