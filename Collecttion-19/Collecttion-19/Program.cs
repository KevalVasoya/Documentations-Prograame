namespace Collecttion_19
{
    public class Prograam
    {
        static void Main(string[] args)
        {
            var primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.WriteLine("No of primeNumber: " + primeNumbers.Count);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null); // null is allowed

            Console.WriteLine("No of Cities: " + cities.Count);

            // adding elements using collection initializer syntax
            var bigCities = new List<string>() { "New York", "Mumbai", "Chicago" };

            Console.WriteLine("No of BigCities: " + bigCities.Count);

            var students = new List<Student>() {
            new Student(){ Id = 1, Name="Keval"},
            new Student(){ Id = 2, Name="Darshil"},
            new Student(){ Id = 3, Name="Nirav"},
            new Student(){ Id = 4, Name="Soham"}
        };

            Console.WriteLine("No of Student: " + students.Count);
        }
    }
}