using System;
using System.IO;

class ImageUploader
{
    /// <summary>Defines the entry point of the application.</summary>
    /// <exception cref="System.IO.FileNotFoundException">The specified file was not found.</exception>
    static void Main()
    {
        try
        {
            Console.WriteLine("Please provide the path to the image file:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file was not found.");
            }

            Console.WriteLine("Please provide the destination folder path:");
            string destinationFolderPath = Console.ReadLine();


            // give a path 
            string fileName = Path.GetFileName(filePath);

            // Give a path to image save
            string destinationPath = Path.Combine(destinationFolderPath, fileName);

            // Copy the file to the destination path
            File.Copy(filePath, destinationPath, true);



            Console.WriteLine("Image uploaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while uploading the image:");
            Console.WriteLine(ex.Message);
        }
    }
}
