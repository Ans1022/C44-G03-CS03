using System;
using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q6
            //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen            int original = 50;
            Person person1 = new Person();
            person1.Name = "Anas";

            Person person2 = person1;

            person2.Name = "Mohamed";

            Console.WriteLine("person1.Name: " + person1.Name);
            Console.WriteLine("person2.Name: " + person2.Name);
            #endregion

        }

    }
}
    

