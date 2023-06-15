namespace Constructor
{
    public class Costructor
    {
        int number1, number2;
        int sum;


        /// <summary>Initializes a new instance of the <see cref="Costructor" /> class.</summary>


        public Costructor() //Constructor without Parameter
        {
            number1 = 10;
            number2 = 20;
            sum = number1 + number2;
        }

        /// <summary>Initializes a new instance of the <see cref="Costructor" /> class.</summary>
        /// <param name="number3">The number3.</param>
        /// <param name="number4">The number4.</param>

        public Costructor(int number3, int number4)  //Constructor with Parameter

        {
            number1 = number3;
            number2 = number4;

        }
    }
}
