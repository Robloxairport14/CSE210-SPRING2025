using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int random = new Random().Next(1, 100);
        int attempts = 1;
        int guess = 0;
        while (guess != random)
        {
            Console.WriteLine("Guess a number between 1 and 100:");
            guess = int.Parse(Console.ReadLine());

            if (guess < random)
            {
                Console.WriteLine("Too low! Try again:");
            }
            else if (guess > random)
            {
                Console.WriteLine("Too high! Try again:");
            }
            else
            {
                Console.WriteLine("Congratulations! You've guessed the number!");
                Console.WriteLine($"It took you {attempts} attempts.");
            }
            attempts++;
        }
    }
}