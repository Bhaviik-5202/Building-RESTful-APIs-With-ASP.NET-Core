using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_03_OOP
{
    internal class PremiumCar
    {
        private string Make;
        private string Model;
        private int Year;
        private string FuelType;
        private double Horsepower;

        public PremiumCar(string make, string Model, int Year, string FuelType, double HorsePower)
        {
            Make = make;
            Model = Model;
            Year = Year;
            FuelType = FuelType;
            Horsepower = HorsePower;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Premium Sports Car Details:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Horsepower: {Horsepower} HP");
        }
    }
}
