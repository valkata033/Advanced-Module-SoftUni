using System;
using System.Collections.Generic;
using System.Linq;

namespace RowData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split();

                string model = inputData[0];
                int engineSpeed = int.Parse(inputData[1]);
                int enginePower = int.Parse(inputData[2]);
                int cargoWeight = int.Parse(inputData[3]);
                string cargoType = inputData[4];

                List<Tire> tires = new List<Tire>();

                for (int tireIndex = 5; tireIndex <= 12; tireIndex += 2)
                {
                    double tirePressure = double.Parse(inputData[tireIndex]);
                    int tireAge = int.Parse(inputData[tireIndex + 1]);

                    Tire tire = new Tire(tireAge, tirePressure);
                    tires.Add(tire);
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string cargoTypes = Console.ReadLine();

            if (cargoTypes == "fragile")
            {
                List<Car> fragile = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1))
                    .ToList();

                foreach (var item in fragile)
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                List<Car> flammable = cars
                    .Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250)
                    .ToList();

                foreach (var item in flammable)
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}
