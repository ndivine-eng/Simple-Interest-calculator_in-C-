using System;

class SimpleInterestCalculator
{
    static void Main()
    {
        // Step 1: Initialize variables
        double principal = 0;
        double rate = 0;
        double time = 0;
        double interest = 0;

        // Step 2: Display initial values
        Console.WriteLine("=======================================");
        Console.WriteLine("      SIMPLE INTEREST CALCULATOR       ");
        Console.WriteLine("=======================================");
        Console.WriteLine("\nInitial Values:");
        Console.WriteLine("Principal = 0, Rate = 0, Time = 0, Interest = 0");

        // Step 3: Read input from user
        Console.Write("\nEnter the Principal amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of Interest (in %): ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time (in years): ");
        time = Convert.ToDouble(Console.ReadLine());

        // Step 4: Calculate Simple Interest
        interest = (principal * rate * time) / 100;

        // Step 5: Display the calculated interest
        Console.WriteLine("\n---------------------------------------");
        Console.WriteLine($"Principal      : {principal}");
        Console.WriteLine($"Rate (%)       : {rate}");
        Console.WriteLine($"Time (years)   : {time}");
        Console.WriteLine($"Simple Interest: {interest}");
        Console.WriteLine("---------------------------------------");
    }
}
