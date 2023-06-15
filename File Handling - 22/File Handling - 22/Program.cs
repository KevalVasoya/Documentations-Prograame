namespace ReadWriteFile
{

    public class handle
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            string data;
            StreamReader reader = null;
            try
            {
                 reader = new StreamReader("C:\\myTestFile.txt");
                data = reader.ReadLine();   

                while (data != null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                reader.Close();
            }
        }
    }
}
