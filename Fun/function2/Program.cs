using System;

class Program
{
    static void GreetUser(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine(); // User inputs their name
        GreetUser(userName); // Pass the user input to GreetUser
    }
}

