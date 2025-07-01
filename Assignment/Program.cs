using System;
using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q11
            //Write a program that takes the date from the user and displays it in various formats using string interpolation
            Console.Write("Enter the day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Today's date : {day} , {month} , {year}");
            Console.WriteLine($"Today's date : {day} / {month} / {year}");
            Console.WriteLine($"Today's date : {day} – {month} – {year}");
            #endregion

        }

    }
}
    

