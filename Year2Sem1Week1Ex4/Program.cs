using System;

namespace Year2Sem1Week1Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] scores = new string[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter in {i} score");
                scores[i] = Console.ReadLine();
            }

            Array.Sort(scores);
            Array.Reverse(scores);


            for (int i = 0; i < 6; i++)
                Console.WriteLine(scores[i]);

        }
    }
}
