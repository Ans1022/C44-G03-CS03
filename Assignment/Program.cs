namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q5
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int original = 50;
            Console.WriteLine($"Original value: {original}");

            int copy = original;
            Console.WriteLine($"before modification: {copy}");
            copy = 100;
            Console.WriteLine("After modification:");
            Console.WriteLine($"Original value: {original}");
            Console.WriteLine($"Copy value: {copy}");
            #endregion

        }

    }
}
    

