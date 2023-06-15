public class AddDictionary
{
    /// <summary>Defines the entry point of the application.</summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        Dictionary <string,string> StudentList= new Dictionary<string,string> ();

        StudentList.Add("Keval","BCA");
        StudentList.Add("Parth", "BE");
        StudentList.Add("Darshil", "Bcom");       

        try
        {
            
            StudentList.Add("Nirav", "B.e");
           
        }
        
        catch (ArgumentException)
        {
           
            Console.WriteLine("An element with key" + "= \"Nirav\" already exists.");
        }



        foreach (KeyValuePair<string,string> qdev in StudentList)
        {
            Console.WriteLine("key = {0},Value = {1}",qdev.Key,qdev.Value);
        }


        Console.WriteLine("Total Index of  your employee: " + StudentList.Count);

    }
}