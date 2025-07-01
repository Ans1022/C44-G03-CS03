using System;
using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q9
            //Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BM
            double weight, height, bmi;

            Console.Write("Enter weight in kilograms: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height in meters: ");
            height = Convert.ToDouble(Console.ReadLine());

            bmi = weight / (height * height);
            Console.WriteLine("Your Body Mass Index is: " + bmi);
            #endregion

        }

    }
}
    

