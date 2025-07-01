using System;
using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q10
            //Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is 
            Console.Write("Enter the degrees: ");
            int degrees = Convert.ToInt32(Console.ReadLine());

            string result = (degrees < 10) ? "Just Cold" :
                            (degrees > 30) ? "Just Hot"  : "Just Good";
                           

            Console.WriteLine("The weather is: " + result);
            #endregion

        }

    }
}
    

