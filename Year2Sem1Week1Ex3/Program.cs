using System;

namespace Year2Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hOrO;
            int result;
            int points;

            Console.WriteLine("higher or ordinary? (h/o): ");
            hOrO = Console.ReadLine();

            if (hOrO == "h")
            {

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

            else if (hOrO == "o")
            {
                Console.WriteLine("Enter result");
                result = int.Parse(Console.ReadLine());





                if (result >= 90)
                    points = 56;

                else if (result >= 80)
                    points = 46;

                else if (result >= 70)
                    points = 37;

                else if (result >= 60)
                    points = 28;

                else if (result >= 50)
                    points = 20;

                else if (result >= 40)
                    points = 12;

                else
                    points = 0;

                Console.WriteLine($"ur score was {result} and ur points {points}");
            }
        }
    }
}
