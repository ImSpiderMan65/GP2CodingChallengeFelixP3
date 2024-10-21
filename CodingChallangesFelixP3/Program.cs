using System;
class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my challenge program! There will be a variety of different functions to choose from. Please pick one.");

        while (true)
        {
            Console.WriteLine("\nAvailable Functions:");
            Console.WriteLine("1: Sum two numbers");
            Console.WriteLine("2: Convert minutes to seconds");
            Console.WriteLine("3: Add one to a number");
            Console.WriteLine("4: Calculate power from voltage and current");
            Console.WriteLine("5: Age in days");
            Console.WriteLine("6: Calculate the area of a triangle");
            Console.WriteLine("7: Check if a number is less than or equal to zero");
            Console.WriteLine("8: Exit");
            Console.Write("Enter the number of your choice: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformSum();
                    break;
                case "2":
                    PerformConversion();
                    break;
                case "3":
                    PerformAddOne();
                    break;
                case "4":
                    PerformCircuit();
                    break;
                case "5":
                    PerformAgeing();
                    break;
                case "6":
                    PerformArea();
                    break;
                case "7":
                    PerformLessthan0();
                    break;
                case "8":
                    Console.WriteLine("Thank you for using the program. Goodbye!");
                    return; // Exit the program
                default:
                    Console.WriteLine("Error: The function you requested does not exist. Please choose a valid option.");
                    break;
            }
        }
    }

    public static void PerformSum()
    {
        Console.WriteLine("\nPlease input two numbers to add.");
        Console.Write("First number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"The sum of {number1} and {number2} is: {Sum(number1, number2)}\n");
    }

    public static void PerformConversion()
    {
        Console.WriteLine("\nGive me a number to convert from minutes to seconds.");
        int number3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"{number3} Minute(s) converted into seconds is: {Convert(number3)}\n");
    }

    public static void PerformAddOne()
    {
        Console.WriteLine("\nPlease pick a number to add 1 to.");
        int number4 = int.Parse(Console.ReadLine());
        Console.WriteLine($"The number you have chosen plus 1 is: {AddOne(number4)}\n");
    }

    public static void PerformCircuit()
    {
        Console.WriteLine("\nPlease enter a number for voltage.");
        int voltage = int.Parse(Console.ReadLine());
        Console.WriteLine("Now put in a number for current.");
        int current = int.Parse(Console.ReadLine());
        Console.WriteLine($"The calculated power is: {Circuit(voltage, current)}\n");
    }

    public static void PerformAgeing()
    {
        Console.WriteLine("\nPlease enter your age.");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your age in days is: {Ageing(age)}\n");
    }

    public static void PerformArea()
    {
        Console.WriteLine("\nPlease insert a value for the base of the triangle.");
        int baseLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Now put in a height.");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine($"The area of the triangle is: {Area(baseLength, height)}\n");
    }

    public static void PerformLessthan0()
    {
        Console.WriteLine("\nPlease type in a number to check if it's less than or equal to zero.");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Lessthan0(number) ? "True: The number is less than or equal to zero." : "False: The number is greater than zero.");
    }

    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int number)
    {
        return number * 60;
    }

    public static int AddOne(int number)
    {
        return number + 1;
    }

    public static int Circuit(int voltage, int current)
    {
        return voltage * current;
    }

    public static int Ageing(int age)
    {
        return age * 365;
    }

    public static float Area(int baseLength, int height)
    {
        return (baseLength * height) / 2f;
    }

    public static bool Lessthan0(int number)
    {
        return number <= 0;
    }
}
