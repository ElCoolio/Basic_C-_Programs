using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        //int[] testScores = { 98, 99, 85, 60, 44, 91, 75, 81, 86, 92 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing Test Score: " + testScores[i]);
        //    }
        //}


        //string[] names = { "Stephen", "Michael", "Daniel", "Kevin", "William" };

        //for (int i = 0; i < names.Length; i++)
        //{
        //    Console.WriteLine(names[i]);
        //}

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(85);
        //testScores.Add(60);
        //testScores.Add(44);
        //testScores.Add(91);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing Test Score: " + score);
        //    }
        //}

        //List<String> names = new List<string>() { "Stephen", "Michael", "Daniel", "Kevin", "William" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}

        List<int> passingScores = new List<int>();
        List<int> testScores = new List<int>() { 98, 99, 85, 60, 44, 91, 75, 81, 86, 92 };

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine(passingScores.Count);
        Console.ReadLine();

    }
}

