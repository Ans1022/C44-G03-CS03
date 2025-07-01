using System;
using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q15
            //What will be the output of the C# code given below?
            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            // output = 7  7
            #endregion



        }

    }
}