using System;
using System.IO;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = GetInput();
            
            ASide(input);
            BSide(input);
        }


        static void ASide(string input)
        {
            //TODO: Complete Part 1
        }


        static void BSide(string input)
        {
            //TODO: Complete Part 2
        }


        static string GetInput()
        {
            string fileContent = "[Empty File]";

            if (File.Exists("Input.txt"))
                fileContent = File.ReadAllText("Input.txt");

            return fileContent;
        }
    }
}
