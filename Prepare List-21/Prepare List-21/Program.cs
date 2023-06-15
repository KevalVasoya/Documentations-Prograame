public class ListLike
{

    /// <summary>Defines the entry point of the application.</summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        List<char> Alphabet = new List<char>();

        Alphabet.Add('A');
        Alphabet.Add('B');
        Alphabet.Add('C');
        Alphabet.Add('D');
        Alphabet.Add('E');
        Alphabet.Add('F');
        Alphabet.Add('F');
        Alphabet.Add('F');
        Alphabet.Add('F');

        Console.WriteLine("Your Total Alphabet: " + Alphabet.Count);

        foreach(Char number in Alphabet)
        {
           
            Console.WriteLine(number);
        }


        List<char> distinct = Alphabet.Distinct().ToList();

        Console.WriteLine("List after removing duplicate elements ...");
        Console.WriteLine("Your Total Alphabet: " + distinct.Count);

        foreach (char res in distinct)
        {
            Console.WriteLine("{0}", res);
        }
        
    }  


}