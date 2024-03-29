﻿using System.IO;

namespace ArchiveClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\C# - Files\file1.txt";
           
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr  != null) sr.Close();
            }
        }
    }
}