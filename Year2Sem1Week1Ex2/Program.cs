using System;

namespace Year2Sem1Week1Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            int points = 0;


            Console.WriteLine("Enter in result");
            input = Console.ReadLine().ToLower();


            switch(input)
            {
                case "h1":
                    points = 100;
                    break;

                case "h2":
                    points = 88;
                    break;

                case "h3":
                    points = 77;
                    break;

                case "h4":
                    points = 66;
                    break;

                case "h5":
                    points = 56;
                    break;

                case "h6":
                    points = 46;
                    break;

                case "h7":
                    points = 37;
                    break;

                case "o1":
                    points = 56;
                    break;

                case "o2":
                    points = 46;
                    break;

                case "o3":
                    points = 37;
                    break;

                case "o4":
                    points = 28;
                    break;

                case "o5":
                    points = 20;
                    break;

                case "o6":
                    points = 12;
                    break;

                default:
                    break;

                    


            }
            Console.WriteLine(points);
        }
    }
}
