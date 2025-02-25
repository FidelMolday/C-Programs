using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine()); // 'Convert' is correctly capitalized

        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is an even number");
        }
        else
        {
            Console.WriteLine(number + " is an odd number");
        }
    }
}
