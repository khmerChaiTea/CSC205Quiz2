using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize an array with some unsorted values
        int[] a = { 3, 2, 5, 1, 4 };

        // Variable to temporarily hold values during swapping
        int tmp;

        // Print the original array
        Console.WriteLine("The original array: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " "); // Print each element followed by a space
        }
        Console.WriteLine(); // Print a newline for better readability

        // Nested for loops to sort the array using Bubble Sort algorithm
        for (int i = 0; i < a.Length - 1; i++)
        {
            // Inner loop performs comparisons and swaps for the current pass
            for (int j = 0; j < a.Length - 1 - i; j++)
            {
                // Compare adjacent elements
                if (a[j] > a[j + 1])
                {
                    // Swap if the current element is greater than the next element
                    tmp = a[j + 1]; // Temporarily hold the value of the next element
                    a[j + 1] = a[j]; // Move the current element to the next position
                    a[j] = tmp; // Place the previously next element into the current position
                }
            }
        }

        // Print the modified (sorted) array
        Console.WriteLine("\nThe modified array:");
        foreach (int i in a)
        {
            Console.Write(i + " "); // Print each element followed by a space
        }
        Console.WriteLine(); // Print a newline for better readability

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}



