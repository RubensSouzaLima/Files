using System.IO;

namespace ArchiveClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\C# - Files\file1.txt";
            string targetPath = @"C:\C# - Files\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.ToString());
            }
        }
    }
}