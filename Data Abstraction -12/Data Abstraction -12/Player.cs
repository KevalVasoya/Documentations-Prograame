namespace Data_Abstraction__12
{
    public abstract class player    //abstract class
    {
        public abstract void fullName();
        public void Name()
        {
            Console.WriteLine("Keval");
        }
    }

    public class player2 : player          //derived class
    {
        /// <summary>Fulls the name.</summary>
        public override void fullName()
        {
            Console.WriteLine("Keval Vasoya");

        }
    }
}
