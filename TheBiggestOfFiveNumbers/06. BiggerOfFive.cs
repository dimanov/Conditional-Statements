/*
 * Problem 6. The Biggest of Five Numbers
 * Write a program that finds the biggest of five numbers by using only five if statements.
 */

using System;

class BiggerOfFive
{
    static void Main()
    {
        Console.Write("Please enter five numbers: \na= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d= ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e= ");
        double e = double.Parse(Console.ReadLine());

        //Use "bubble sort" algorithm
        int n = 5;

        double[] Numbers = { a, b, c, d, e };
        int index;
        double comparison = Numbers[0];
        for (index = 1; index < n; index++)
        {

            if (comparison > Numbers[index])
            {
                Numbers[index] = comparison;
            }
            else 
            {
                comparison = Numbers[index];
            }
        }
        Console.WriteLine("The bigest number is: {0}", comparison);
    }
}