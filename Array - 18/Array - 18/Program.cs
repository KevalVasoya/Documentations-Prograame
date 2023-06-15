enum Position
{
    CEO,
    Senior,
    Freshers,
    Traniee
}
public class Employy
{

    static void Main(string[] args)
    {
        string[] name = { "Keval", "Nirav", "Darshil", "Parth", "Soham", "Himani", "Harshida" };
        Console.Write("\nPost:");
        Position CEO = Position.CEO;
        Console.WriteLine(CEO);
        Console.WriteLine("CEO's Name:-");
        Console.WriteLine(name[3]);

        Console.Write("\nPost:");
        Position senior = Position.Senior;
        Console.WriteLine(senior);
        Console.WriteLine("Senior Name:-");
        Console.WriteLine(name[4]);
        Console.WriteLine(name[1]);

        Console.Write("\nPost:");
        Position freshers = Position.Freshers;
        Console.WriteLine(freshers);
        Console.WriteLine("Fresher Name:-");
        Console.WriteLine(name[0]);
        Console.WriteLine(name[2]);

        Console.Write("\nPost:");
        Position Traniee = Position.Traniee;
        Console.WriteLine(Traniee);
        Console.WriteLine("Trainee Name:-");
        Console.WriteLine(name[5]);
        Console.WriteLine(name[6]);

        // adding elements using add() method
        var primeNumbers = new List<int>();
        primeNumbers.Add(1);
        primeNumbers.Add(3);
        primeNumbers.Add(5);
        primeNumbers.Add(7);
    }
}




