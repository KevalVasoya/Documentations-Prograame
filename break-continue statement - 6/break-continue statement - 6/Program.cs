public class Number
{
    /// <summary>Defines the entry point of the application.</summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string []args)
    {
       int i = 0;

        while (i  <= 10) //start condition
        {
            Console.WriteLine(i);
            i++;
            if (i == 80)   //continue statement
            {
                i++;
                continue;
                
            }
            else if (i == 8)  //break statement
            {
                break;
            }
        }
    }
}
