using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] scores = { 45, 40, 50, 30, 25, 60, 55, 33, 41, 37, 48, 53, 20, 19, 59, 62, 44, 51, 49, 47 };

        int[] sortedScores = scores.OrderByDescending(x => x).ToArray();

        int top3Sum = sortedScores[0] + sortedScores[1] + sortedScores[2];

        Console.WriteLine($"The sum of the points of the first 3 teams: {top3Sum}");
    }
}
