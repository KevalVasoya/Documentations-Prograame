namespace If_else_condition___2
{
    public class Student
    {

        /// <summary>Initializes a new instance of the <see cref="Student" /> class.</summary>
        public Student()
        {
            Console.WriteLine("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 6)    //To cheack age 
            {

                Console.WriteLine("Your age is to play.");
            }
            else if (age >= 20)
            {
                Console.WriteLine("You are to late too start study.");
            }
            else
            {
                Console.WriteLine("You age is enable to start study.");

            }
        }


    }
}