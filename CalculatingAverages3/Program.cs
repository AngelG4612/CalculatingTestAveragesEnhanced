using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAverages3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many tests are you grading? ");
            int Max = int.Parse(Console.ReadLine());







            double scoreSum = 0;
            for (int i = 1; i <= Max; i++)
            {

                Console.Write($"What is the score for test {i}? ");
                double testScore = double.Parse(Console.ReadLine());
                if (testScore < 0 || testScore > 100)
                {
                    Console.Write("invalid score please enter score again");
                    double testScrore = double.Parse(Console.ReadLine());
                }

                scoreSum += testScore;


            }

            Console.Write("Grade: {0}"  ,Average(scoreSum, Max));
            Console.Write(Grade(Average(scoreSum, Max)));
            Console.ReadLine();


        }

        static double Average(double scoreSum, int Max)
        {
            return scoreSum / Max;
        }


        static string Grade(double Average)
        {


            if (Average >= 90)
            {
                return " = A";
            }

            if (Average >= 80 && Average < 90)
            {
                return " = B";
            }

            if (Average >= 70 && Average < 80)
            {
                return " = C";
            }

            if (Average >= 60 && Average < 70)
            {
                return " = D";
            }


            else if (Average < 60)
            {
                return " = F";
            }
            return " ";
        }
    }
}
