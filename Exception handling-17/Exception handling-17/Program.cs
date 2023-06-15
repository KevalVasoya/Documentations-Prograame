public class Prograam
{
    /// <summary>Cheacks the age.</summary>
    /// <param name="age">The age.</param>
    /// <exception cref="System.ArithmeticException">Access denied - You must be at least 18 years old.</exception>
    public static void CheackAge(int age)
    {       
        {
            if (age < 18)
            {
                throw new ArgumentException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted-You are old Enough.");
            }      
        }       
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        

        try                                 // Condition Cheack
        {
                     
            int c =  age - 21;
            Console.WriteLine(c);
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex);
        }
        finally 
        {
            Console.WriteLine("Your age is cheacking by System,");
            Console.WriteLine("Please Wait for few Second.");
            Thread.Sleep(5000);
        }
        CheackAge(age);
    }
}