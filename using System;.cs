using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Get package weight
        Console.WriteLine("Please enter the package weight:");
        float weight = float.Parse(Console.ReadLine());

        // Check if package is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Get package dimensions
        Console.WriteLine("Please enter the package width:");
        float width = float.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the package height:");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the package length:");
        float length = float.Parse(Console.ReadLine());

        // Check if package is too big
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate shipping quote
        float quote = (height * width * length * weight) / 100;

        // Display quote
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}