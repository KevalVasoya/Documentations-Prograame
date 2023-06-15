public class Wrapping
{
    /// <summary>Defines the entry point of the application.</summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
         string greeting = "Hello ";
         Console.WriteLine(greeting);

         string greeting2 = "Nice to Meet You! ";
         Console.WriteLine(greeting2);

   
         Console.WriteLine("the length of the text string is : " + greeting2.Length); //textLength  Method

         string All= string.Concat( greeting , greeting2);     //concat Method   
         Console.WriteLine(All);    

         Console.WriteLine(greeting2[1]);   //chatAt Method

         Console.WriteLine(greeting.Equals(greeting2)); //equals Method

         string setFormat = string.Format("Hello Everyone {0}" , greeting2);  //Formate method
         Console.WriteLine(setFormat);



        int charPos = greeting2.IndexOf("M");            //SubString Method
        string lastName = greeting2.Substring(charPos);     
        Console.WriteLine(lastName);


    }
}