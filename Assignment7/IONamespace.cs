using System;
using System.IO;

namespace BasicIO
{
    class Program
    { 
        static void Main()
        {
            string path2 = Path.GetTempFileName();
            var fi1 = new FileInfo(path2);

            // Create a file to write to.
            using (StreamWriter sw = fi1.CreateText())
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }

            // Open the file to read from.
            using (StreamReader sr = fi1.OpenText())
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            string[] text = File.ReadAllLines(@"C:\Users\Sagar\Desktop\archive\sample.txt");
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }

            
            string path = @"C:\Users\Sagar\Desktop\sample2";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully.");

                // Delete the directory.
                di.Delete();
                Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }


            string sourceDirectory = @"C:\Users\Sagar\Desktop\archive";
            string archiveDirectory = @"C:\Users\Sagar\Desktop\sample";

            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");

                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}