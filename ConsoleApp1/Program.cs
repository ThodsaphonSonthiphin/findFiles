using System;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"/Users/thodsaphonsonthiphin/Downloads";
            

            var docFile = Directory.EnumerateFiles(sourceDirectory, "*.docx", SearchOption.AllDirectories);
            
            foreach (string currentFile in docFile)
            {
                Console.WriteLine(currentFile);
            }


        }
    }
}