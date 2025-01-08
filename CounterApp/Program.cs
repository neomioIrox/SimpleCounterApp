using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        string input;

        Console.WriteLine("Welcome to the Counter App!");

        do
        {
            Console.Write($"Counter: {counter} > ");
            input = Console.ReadLine()?.Trim().ToLower();
            counter++;
            
        } while (input != "exit");
    }
}
