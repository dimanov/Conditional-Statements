/*
 * Problem 9. Play with Int, Double and String
 * Write a program that, depending on the user’s choice, inputs an  int ,  double  or  string  variable. 
 * If the variable is  int  or  double , the program increases it by one.
 * If the variable is a  string , the program appends  *  at the end.
 * Print the result at the console. Use switch statement.
 */

using System;

class DoubleOrString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": Console.WriteLine("Please enter an integer: ");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
                break;
            case "2": Console.WriteLine("Please enter a double: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case "3": Console.WriteLine("Please enter a string: ");
                string word = Console.ReadLine();
                Console.WriteLine(word + '*');
                break;
            default: Console.WriteLine("Invalid choice."); break;

        }
    }
}