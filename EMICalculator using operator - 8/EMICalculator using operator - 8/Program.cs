namespace EMICalculator_using_operator___8
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public  static void Main(String[] args)
        {
            float price, rate, time, emi;
            Console.WriteLine("Enter Your price(amount): ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your rate: ");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Time period(years): ");
            time = Convert.ToInt32(Console.ReadLine());


            emi = Emi_calculator(price, rate, time);
            Console.WriteLine("Monthly EMI is = " + emi);
        }

    }
}
