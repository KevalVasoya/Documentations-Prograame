public class PrintNumber
{
    /// <summary>Defines the entry point of the application.</summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        int i = 0;
        while (i <= 80)
        {
            continue;
        }

        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i <= 100); //condition & break point
    }
}