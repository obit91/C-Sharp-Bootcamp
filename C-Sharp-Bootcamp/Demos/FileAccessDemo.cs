using System;
using System.IO;

namespace C_Sharp_Bootcamp.Demos.IO
{
    class FileAccessResources
    {
        public const string WRITE_FILE_PATH = @"Path\to\first\file";
        public const string READ_FILE_PATH = @"Path\to\second\file";
    }
}

namespace C_Sharp_Bootcamp.Demos.IO.Write
{

    using C_Sharp_Bootcamp.Demos.IO.Read;

    class FileAccessWriteDemo
    {
        internal static void InnerMain()
        {
            string filePath = FileAccessResources.WRITE_FILE_PATH;
            try
            {
                WriteAllLines(filePath);
                FileAccessReadDemo.ReadAsText(filePath);
                WriteText(filePath);
                FileAccessReadDemo.ReadAsText(filePath);
                WriteWithStream(filePath);
                FileAccessReadDemo.ReadAsText(filePath);
                AppendToFile(filePath);
                FileAccessReadDemo.ReadAsText(filePath);
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            System.Console.ReadKey();
        }

        private static void WriteAllLines(string filePath)
        {
             Console.WriteLine("First write.");
            // WriteAllLines creates a file, writes a collection of strings to the file and then closes it.
            string[] lines = { "First line", "Second line", "Third line" };
            System.IO.File.WriteAllLines(filePath, lines);
        }

        private static void WriteText(string filePath)
        {
            Console.WriteLine("Second write.");
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().

            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            System.IO.File.WriteAllText(filePath, text);
        }
        
        private static void WriteWithStream(string filePath)
        {
            Console.WriteLine("Third write.");
            // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
            // encodes the output as text.

                string[] lines = { "First line from stream", "Second line from stream", "Third line from stream" };
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }

        private static void AppendToFile(string filePath)
        {
            Console.WriteLine("Fourth write.");

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
            {   
                file.WriteLine("Fourth line appended");
            }
        }
     }
 }

namespace C_Sharp_Bootcamp.Demos.IO.Read
{
    class FileAccessReadDemo
    {
        internal static void InnerMain()
        {
            string filePath = FileAccessResources.READ_FILE_PATH;
            try
            {
                ReadAsText(filePath);
                ReadFileToArray(filePath);
                System.Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        internal static void ReadAsText(string filePath)
        {
            Console.WriteLine("First read.");
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(filePath);
            Console.WriteLine(text);
        }

        internal static void ReadFileToArray(string filePath)
        {
            Console.WriteLine("Second read.");
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
