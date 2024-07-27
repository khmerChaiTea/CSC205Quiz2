using System;

class Program
{
    // Method to create an array of integers where each element is initialized to its 1-based index value
    static int[] Make(int n)
    {
        // Initialize the array with size n
        int[] a = new int[n];
        // Populate the array with values from 1 to n
        for (int i = 0; i < n; i++)
        {
            a[i] = i + 1; // Set the element at index i to i + 1
        }
        return a; // Return the populated array
    }

    // Method to double each value in the given integer array
    static void Dub(int[] jub)
    {
        // Iterate through the array and double each element
        for (int i = 0; i < jub.Length; i++)
        {
            jub[i] *= 2; // Double the value at index i
        }
    }

    // Method to compute the sum of all elements in the given integer array
    static int Mus(int[] zoo)
    {
        int fus = 0; // Variable to store the sum
        // Iterate through the array and accumulate the sum
        foreach (int z in zoo)
        {
            fus += z; // Add each element to the sum
        }
        return fus; // Return the computed sum
    }

    // Main method to test the other methods
    static void Main()
    {
        // Create an array with values from 1 to 5 using the Make method
        int[] bob = Make(5);

        // Print the original array
        Console.WriteLine("Original array:");
        foreach (int value in bob)
        {
            Console.Write(value + " "); // Print each value followed by a space
        }
        Console.WriteLine(); // Print a newline for better readability

        // Double the values in the array using the Dub method
        Dub(bob);

        // Print the modified array
        Console.WriteLine("Modified array:");
        foreach (int value in bob)
        {
            Console.Write(value + " "); // Print each doubled value followed by a space
        }
        Console.WriteLine(); // Print a newline for better readability

        // Calculate and print the sum of the array elements using the Mus method
        Console.WriteLine("Sum of array elements:");
        Console.WriteLine(Mus(bob)); // Print the sum of the array elements
    }
}


