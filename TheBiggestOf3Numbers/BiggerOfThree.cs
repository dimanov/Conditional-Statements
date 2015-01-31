/*
 * Problem 5. The Biggest of 3 Numbers
 * Write a program that finds the biggest of three numbers.
 */

using System;

class BiggerOfThree
{
    static void Main()
    {
        Console.Write("Please enter the first number: x= ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: y=");
        double y = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: z= ");
        double z = double.Parse(Console.ReadLine());

        //find maximum of any 2 pairs
        double bigger1 = Math.Max(x,y);
        double bigger2 = Math.Max(x,z);
        //compare maximums of the 2 pairs
        Console.WriteLine(bigger1>bigger2 ? bigger1 : bigger2);            
    }
}