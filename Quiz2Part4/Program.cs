using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two different Car objects using the parameterized constructor
            Car car1 = new Car("1HGBH41JXMN109186", "Toyota", "Camry", 25000);
            Car car2 = new Car("2HGBH41JXMN109187", "Honda", "Civic", 15000);

            // Call the Drive method for each car to increase mileage
            car1.Drive(150); // Increase car1's mileage by 150 miles
            car2.Drive(300); // Increase car2's mileage by 300 miles

            // Call the Display method for each car to print their details
            Console.WriteLine("Details of Car 1:");
            car1.Display();  // Display the details of car1

            Console.WriteLine("\nDetails of Car 2:");
            car2.Display();  // Display the details of car2

        }
    }
}
