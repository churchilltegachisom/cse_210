using System;

class Program
{
    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt for and return user name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt for and return favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display result
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

    // Main function
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);

        DisplayResult(userName, square);
    }
}
