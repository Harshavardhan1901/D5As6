using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][];

            // Initialize studentScores array with scores
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };

            // Print scores of each student
            Console.WriteLine("Scores of each student:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write("Student " + (i + 1) + ": ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Calculate and print average score for each student
            Console.WriteLine("Average score for each student:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                double averageScore = CalculateAverage(studentScores[i]);
                Console.WriteLine("Student " + (i + 1) + ": " + averageScore);
            }

            Console.WriteLine();

            // Calculate and print average score for all students combined
            Console.WriteLine("Average score for all students combined:");
            double totalAverage = CalculateAverageForAll(studentScores);
            Console.WriteLine(totalAverage);

            Console.ReadLine();
        }

        // Function to calculate average score for an array of scores
        static double CalculateAverage(int[] scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return (double)sum / scores.Length;
        }

        // Function to calculate average score for all students combined
        static double CalculateAverageForAll(int[][] scores)
        {
            int totalSum = 0;
            int totalCount = 0;
            foreach (int[] studentScores in scores)
            {
                totalSum += CalculateSum(studentScores);
                totalCount += studentScores.Length;
            }
            return (double)totalSum / totalCount;
        }

        // Function to calculate sum of scores
        static int CalculateSum(int[] scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return sum;
        }
    }
}
