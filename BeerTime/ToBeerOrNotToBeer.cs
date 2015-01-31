/*
 * Problem 10.* Beer Time
 * A beer time is after  1:00 PM  and before  3:00 AM .
 * Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
 * a minute in range [00…59] and AM / PM designator) and prints  beer time  or  non-beer time  
 * according to the definition above or invalid time if the time cannot be parsed.
 */

using System;
using System.IO;

class ToBeerOrNotToBeer
{
    static void Main()
    {

        //StreamReader reader = new StreamReader("..\\..\\Entries.txt"); 
        //Console.SetIn(reader);

        Console.WriteLine("Please enter a time in format “hh:mm tt”");
        DateTime myDateTime = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine(myDateTime.ToShortTimeString());

        //DateTime myTime = MyDateTime.TimeOfDay;
        DateTime startBeerTime = DateTime.Parse("01:00 PM");
        DateTime endBeerTime = DateTime.Parse("3:00 AM");
        DateTime endOfaDay = DateTime.Parse("00:00 AM");

        int result1 = DateTime.Compare(myDateTime, startBeerTime);
        int result2 = DateTime.Compare(endBeerTime, myDateTime);
        int result3 = DateTime.Compare(myDateTime, endOfaDay);

        if ((result2 > 0 && result3 >= 0) || (result1 >= 0 && result3 >= 0))
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}