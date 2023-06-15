namespace Constructor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Costructor Add = new Costructor();
            Costructor Addition = new Costructor(20, 20);
            Console.WriteLine(Add.sum);
            Console.WriteLine(Addition.number1 + Addition.number2);

        }
    }
}