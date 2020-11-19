using System;
using System.IO;

namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDelete();
        }

        public static void FileDelete()
        {
            string rootpath = @"C:\Users\mammu\samples\playerTwo";
            string fileName = "ball.txt";

            if (File.Exists(Path.Combine(rootpath, fileName)))
            {
                File.Delete(Path.Combine(rootpath, fileName));
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }


    }
}
