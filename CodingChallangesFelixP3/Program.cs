using System;
class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my challange program. there will be a variety of different functions to choose from. Please pick one.");

        Console.WriteLine("Today we are going to use the number adder called sum. Please Input two numbers for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome, please put a second numero");

        var number2 =  Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("The sum of the numbers: "  + number1 + " and the number " + number2 + " is equal to: " + Sum(number1int, number2int) + "\n");
        Sum(number1int, number2int);

        Console.WriteLine("Lets try converting minutes to seconds. \nGive me a number to convert from minutes to seconds");
        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);

        Console.WriteLine(number3 + " Minute(s) converted into seconds is " + Convert(number3int) + "\n");

        Console.WriteLine("Sweet lets try to add 1 to a number. Please pick a number.  \n");

        var number4 = Console.ReadLine();
        int number4int = int.Parse(number4);  
        Console.WriteLine("Ok the number you have put plus 1 is " + AddOne(number4int) + "\n");

        Console.WriteLine("Today we are make a function that takes voltage and current and returns the calculated power.");
        Console.WriteLine("please enter a number for a voltage :) \n");
        var voltage = Console.ReadLine();
        int voltageint = int.Parse(voltage);
        Console.WriteLine("Cool now put in a number for a current");
        var current = Console.ReadLine();
        int currentint = int.Parse(current);   
        Console.WriteLine(" The calculated power of these numbers is " + Circuit(voltageint, currentint) + "\n");

        Console.WriteLine(" Now we will tell you your age in days. \n");
        var age = Console.ReadLine();
        int ageint = int.Parse(age);

        Console.WriteLine(" Cool your age in days is " + Ageing(ageint) + "\n");

        Console.WriteLine("Today we are going to make a function that takes the base and height of a triangle and returns its area. \nPlease insert a variable foe the base");
        var basicbase = Console.ReadLine();
        int basicbaseint = int.Parse(basicbase);
        Console.WriteLine("Thanks now put in a height");
        var Height = Console.ReadLine();
        int Heightint = int.Parse(Height);
        Console.WriteLine(" Cool the area is " + Area(basicbaseint, basicbaseint) + "\n");

        Console.WriteLine("Today we are going to see if a number is less than 0 where it will say true if its equal or less than 0 and false if it isnt " + "\n" + "Please type in a number");
        var lessthn = Console.ReadLine();
        int lessthnint = int.Parse(lessthn);
        Console.WriteLine(Lessthan0(lessthnint));

        

    }


    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int number)
    {
        return number * 60;
    }

    public static int AddOne(int number4)
    {
        return number4 + 1;
    }

    public static int Circuit(int voltage, int current)
    {
        return voltage * current;
    }

    public static int Ageing(int age)
    {
        return age * 365;
    }

    public static float Area(int basicbase, float Height)
    {
        return basicbase * Height / 2;
    }

    public static bool Lessthan0(int lessthn)
    {
        if (lessthn <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
