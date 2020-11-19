using System;
using System.IO;

namespace MoveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveFile();
        }
        public static void MoveFile()
        {
            string sourceDirectory = @"C:\Users\mammu\samples\playerOne";
            string destinationPath = @"C:\Users\mammu\samples\playerTwo";
            string fileName = "ball.txt";

            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));

        }


    }


}
