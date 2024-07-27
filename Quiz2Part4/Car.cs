using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2Part4
{
    internal class Car
    {
        // Private fields to store the attributes of the car
        private string vin;    // Vehicle Identification Number
        private string make;   // Make of the car (e.g., Toyota, Honda)
        private string model;  // Model of the car (e.g., Camry, Civic)
        private int mileage;   // Current mileage of the car in miles

        // Parameterized constructor to initialize a Car object with specific values
        public Car(string vin, string make, string model, int mileage)
        {
            this.vin = vin;     // Set the VIN of the car
            this.make = make;   // Set the make of the car
            this.model = model; // Set the model of the car
            this.mileage = mileage; // Set the initial mileage of the car
        }

        // Default constructor to initialize a Car object with default values
        public Car()
        {
            this.vin = "";      // Default VIN is an empty string
            this.make = "";     // Default make is an empty string
            this.model = "";    // Default model is an empty string
            this.mileage = 0;   // Default mileage is 0
        }

        // Method to increase the mileage of the car
        public void Drive(int miles)
        {
            // Check if the number of miles driven is positive
            if (miles > 0)
            {
                mileage += miles;  // Increase the mileage by the given number of miles
            }
            else
            {
                // Inform the user if the miles value is not positive
                Console.WriteLine("Miles driven should be positive");
            }
        }

        // Method to display the car's attributes
        public void Display()
        {
            // Print the car's attributes to the console
            Console.WriteLine($"VIN: {vin}");
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Mileage: {mileage} miles");
        }
    }
}
