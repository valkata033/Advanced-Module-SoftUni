using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, 
            double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Calculation(double distance)
        {
            double maxDistance = FuelAmount / FuelConsumptionPerKilometer;

            if (distance > maxDistance)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            else
            {
                TravelledDistance += distance;

                double usedFuel = distance * FuelConsumptionPerKilometer;

                FuelAmount -= usedFuel;
            }

        }

    }
}

