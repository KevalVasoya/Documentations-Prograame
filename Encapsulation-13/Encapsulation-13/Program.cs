namespace Encapsulation_13
{
    public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            student A = new student();
            A.Id = 3;
            A.Name = "Keval Vasoya";
            A.Description = "Your Health is Well.";
            A.Age = 21;


            Console.Write("Your Student Id: ");
            Console.WriteLine(A.Id);

            Console.Write("Your Name: ");
            Console.WriteLine(A.Name);

            Console.Write("Your description: ");
            Console.WriteLine(A.Description);

            Console.Write("Your Age: ");
            Console.WriteLine(A.Age);
        }

    }
}
