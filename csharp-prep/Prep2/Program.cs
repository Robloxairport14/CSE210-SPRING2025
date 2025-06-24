using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage?");
        int percent = int.Parse(Console.ReadLine());

        int sign = percent % 10;
        string gradesign ="";
        if (sign >= 7)
        {
            gradesign = "+";
        }
        else if (sign < 3)
        {
            gradesign = "-";
        }

        if (percent >= 90)
            {
                Console.WriteLine($"You got an A{gradesign}");
            }
            else if (percent >= 80)
            {
                Console.WriteLine($"You got a B{gradesign}");
            }
            else if (percent >= 70)
            {
                Console.WriteLine($"You got a C{gradesign}");
            }
            else if (percent >= 60)
            {
                Console.WriteLine($"You got a D{gradesign}");
            }
            else
            {
                Console.WriteLine("You got an F");
            }
    }
}