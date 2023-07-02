using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer value between 1 and 100:");
        int userInput;
        while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 100)
        {
            Console.WriteLine("Invalid input. Please enter an integer between 1 and 100:");
        }

        Console.WriteLine("Please specify a series: (even/odd)");
        string seriesType = Console.ReadLine().ToLower();

        Console.WriteLine($"You have selected the {seriesType} series. The numbers between 0 and {userInput} are:");

        for (int i = 0; i <= userInput; i++)
        {
            if (seriesType == "even" && i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else if (seriesType == "odd" && i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
