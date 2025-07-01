using System;
using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q8
            // Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is 
            //Interest = (principal * rate * time) / 100.
            Console.WriteLine("Enter the principal : ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the rate : ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the time : ");
            double time = Convert.ToDouble(Console.ReadLine());

            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Simple Interest = " + interest);
            #endregion

        }

    }
}
    

