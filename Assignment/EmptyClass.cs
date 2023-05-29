using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the elements of the array (space-separated):");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        int[] numbers = Array.ConvertAll(inputArray, int.Parse);

        int[] oddArray = GetOddNumbers(numbers);
        int[] evenArray = GetEvenNumbers(numbers);

        Console.WriteLine("Please enter 'even' or 'odd':");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "even")
        {
            DisplayArray(evenArray);
        }
        else if (userInput == "odd")
        {
            DisplayArray(oddArray);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'even' or 'odd'.");
        }
    }

    static int[] GetOddNumbers(int[] numbers)
    {
        int[] oddArray = Array.FindAll(numbers, number => number % 2 != 0);
        return oddArray;
    }

    static int[] GetEvenNumbers(int[] numbers)
    {
        int[] evenArray = Array.FindAll(numbers, number => number % 2 == 0);
        return evenArray;
    }

    static void DisplayArray(int[] array)
    {
        Console.WriteLine("Result:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
