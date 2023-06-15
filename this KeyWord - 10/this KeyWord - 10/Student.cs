namespace this_KeyWord___10
{
    public class student
    {
        public string name;
        public int age;
        public int id;

        /// <summary>Initializes a new instance of the <see cref="student" /> class.</summary>
        /// <param name="name">The name.</param>
        /// <param name="age">The age.</param>
        /// <param name="id">The identifier.</param>
        public student(string name, int age, int id)   //use of this keyword in constructor
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
    }
}