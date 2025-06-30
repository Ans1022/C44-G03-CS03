namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q4
            //Write C# program that Extract a substring from a given string.

            string mainString = "Hello World!";

            string extracted = mainString.Substring(7, 5);

            Console.WriteLine($"Original string: {mainString}");
            Console.WriteLine($"Extracted substring: {extracted}");
            #endregion

        }

    }
}
    

