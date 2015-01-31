/*
 * Problem 1. Exchange If Greater
 * Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
 */

using System;

class ExchangeNumbers
{
    static void Main()
    {
        Console.Write("Please enter the first variable: a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the first variable: b= ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine(a<b ? "{0} {1}" : "{1} {0}", a, b );
    }
}