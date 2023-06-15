namespace Polymerphisam___15
{
    public class Icc
    {

        public void Player()
        {
            Console.WriteLine("How are you Men! ");
        }
        /// <summary>Players the specified name.</summary>
        /// <param name="name">The name.</param>
        public void Player(string name)
        {
            Console.WriteLine("player :" + name);
        }

        /// <summary>Players the specified rank.</summary>
        /// <param name="rank">The rank.</param>
        public void Player(int rank)
        {
            Console.WriteLine("Player Your Icc Rank is:" + rank);

        }
    }
}
