/*
 * Problem 4. Multiplication Sign
 * Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 * Use a sequence of  if  operators.
 */

using System;

class ProductSign
{
    static void Main()
    {
        Console.Write("Please enter the first number: x= ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: y=");
        double y = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: z= ");
        double z = double.Parse(Console.ReadLine());
        int count = 0;
        //check if any number is equal to 0
        if (x == 0 || y == 0 || z == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            double[] numbers = { x, y, z };
            //check if the number of negative numbers is odd or even
            foreach (double number in numbers)
            {
                if (number < 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine((count % 2 == 0) ? "+" : "-");
        }
    }
}