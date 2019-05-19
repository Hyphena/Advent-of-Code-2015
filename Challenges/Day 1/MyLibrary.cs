using System;
using System.IO;

namespace Day_1
{
    class MyLibrary
    {
        public string GetInput()
        {
            string fileContent = "[Empty File]";

            if (File.Exists("Input.txt"))
                fileContent = File.ReadAllText("Input.txt");

            return fileContent;
        }
    }
}