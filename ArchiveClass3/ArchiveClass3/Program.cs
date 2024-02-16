using System.IO;

namespace ArchiveClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\C# - Files\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An erro ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}