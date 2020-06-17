using System;

namespace Ch2Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.5.1 Input/Output
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //2.5.2 Numeric Types
            Console.WriteLine("What is the length of your rectangle?");
            string input = Console.ReadLine();
            int length = int.Parse(input);
            Console.WriteLine("What is the width of your rectangle?");
            input = Console.ReadLine();
            int width = int.Parse(input);
            double area = length * width;
            Console.WriteLine($"The are of your rectangle is {area} units squared.");

            //2.5.3 More on Numeric Types
            Console.WriteLine("How many miles have you driven?");
            input = Console.ReadLine();
            double miles = double.Parse(input);
            Console.WriteLine($"How many gallons of gas did you use for the {miles}-mile trip?");
            input = Console.ReadLine();
            double gallons = double.Parse(input);
            double milesPerGallon = miles / gallons;
            Console.WriteLine($"For your {miles}-mile trip, you used {gallons} gallons\nand achieved an MPG of {milesPerGallon}.");
        }
    }
}
