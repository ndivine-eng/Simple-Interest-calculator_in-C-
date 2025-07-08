// Pseudo-Code for Simple Interest Calculator
using System;

class Program
{
    static void Main()
    {
        // Step 1: Initialize variables
        double principal = 0, rate = 0, time = 0, interest = 0;

        // Step 2: Display initial state (for debugging)
        Console.WriteLine($"Initial values: P={principal}, R={rate}, T={time}, I={interest}");

        // Step 3: Read inputs
        Console.Write("Enter principal (P): ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate (R %): ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (T years): ");
        time = Convert.ToDouble(Console.ReadLine());

        // Step 4: Calculate interest
        interest = (principal * rate * time) / 100;

        // Step 5: Display results
        Console.WriteLine($"Simple Interest = {interest}");
    }
    
    
    
}
