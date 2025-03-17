using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Car
    {
        // Fields
        private string make;
        private string model;
        private int year;

        // Constructor
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public Car()
        {
            this.make = "Honda";
            this.model = "civic";
            this.year = 2025;
        }

        // Method to display car details
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {year} {make} {model}");
        }

        // Method to honk
        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }

        // Method to update the year
        public void UpdateYear(int newYear)
        {
            year = newYear;
        }
    }
}
