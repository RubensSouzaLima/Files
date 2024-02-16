using System.IO;

namespace Archive
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\C# - Files\file1.txt";
            string targetPath = @"C:\C# - Files\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }            
        }
    }
}