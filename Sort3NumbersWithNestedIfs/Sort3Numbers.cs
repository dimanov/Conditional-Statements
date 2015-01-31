/*
 * Problem 7. Sort 3 Numbers with Nested Ifs
 * Write a program that enters 3 real numbers and prints them sorted in descending order. 
 * Use nested  if  statements.
 * Note: Don’t use arrays and the built-in sorting functionality.
 */

using System;

class Sort3Numbers
{
    static void Main()
    {
        Console.Write("Please enter the first number: a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: c= ");
        double c = double.Parse(Console.ReadLine());
        //This is not optimazie method. It is done on purpose. 
        //It uses the fact that there is only 6 combinations between placements of three numbers
        if (a >= b && b >= c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
        else if (a >= c && c >= b)
        {
            Console.WriteLine("{0} {1} {2}", a, c, b);
        }
        else if (c >= a && a >= b)
        {
            Console.WriteLine("{0} {1} {2}", c, a, b);
        }
        else if (c >= b && b >= a)
        {
            Console.WriteLine("{0} {1} {2}", c, b, a);
        }
        else if (b >= a && a >= c)
        {
            Console.WriteLine("{0} {1} {2}", b, a, c);
        }
        else
        {
            Console.WriteLine("{0} {1} {2}", b, c, a);
        }
    }
}