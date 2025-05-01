using System;

class Program
{

    static double AddNumbers(double a, double b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        // int x = 10;
        // if (x == 10)
        // {
        //     Console.WriteLine("X is 10");
        // }

        // for (int i = 0; i < x; i++)
        // {
        //     Console.WriteLine($"Bob is cool: + {i}");
        // }

        // int x = 0;
        // x++;
        // int y = x++;
        // int z = ++x;
        // Console.WriteLine(x);
        // Console.WriteLine(y);
        // Console.WriteLine(z);

        // List<int> myNumbers = new List<int>();
        // myNumbers.Add(10);
        // myNumbers.Add(99);
        // myNumbers.Add(-123);

        // foreach(int i in myNumbers)
        // {
        //     Console.WriteLine(i);
        // }

        double total = AddNumbers(1233, 457);
        Console.WriteLine(total);
    }
}