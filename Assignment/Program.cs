namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Write a program that allows the user to enter a number then print it
            //Console.Write("Enter a number: ");
            //double number = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"You entered: {number}");
            #endregion

            #region Q2
            string name = "ahmed123";

            // Safe conversion using TryParse
            if (int.TryParse(name, out int number))
            {
                Console.WriteLine($"Converted number: {number}");
            }
            else
            {
                Console.WriteLine("contains non-numeric characters");
                #endregion
            }
        }

    }
}
    

