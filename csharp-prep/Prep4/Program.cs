using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = 1;
        while (num != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }
        int big = numbers[0];
        int Total = 0;
        foreach (int number in numbers)
        {
            if (number != 0)
            {
                Total += number;
            }
            if (number > big)
            {
                big = number;
            }
        }
        Console.WriteLine("The total is: " + Total);
        Console.WriteLine("The average is: " + (Total / (numbers.Count)));
        Console.WriteLine($"The largest number is:{big}");
    }
}