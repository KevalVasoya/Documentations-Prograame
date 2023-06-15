public class Pattern
{
    /// <summary>Defines the entry point of the application.</summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter Your Number : ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)    //outer loop
        {
            for (int j = 1; j <= i; j++) //inner loop
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}