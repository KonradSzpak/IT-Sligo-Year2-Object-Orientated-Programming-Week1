using System;

namespace Year2Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int points;

            Console.WriteLine("Enter result");
            result = int.Parse(Console.ReadLine());

            if (result >= 90)
                points = 100;

            else if (result >= 80)
                points = 88;

            else if (result >= 70)
                points = 77;

            else if (result >= 60)
                points = 66;

            else if (result >= 50)
                points = 56;

            else if (result >= 40)
                points = 46;

            else if (result >= 30)
                points = 37;

            else
                points = 0;

            Console.WriteLine($"ur score was {result} and ur points {points}");
        }
    }
}
