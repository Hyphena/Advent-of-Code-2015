using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Day_5
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
            string[] strings = Regex.Split(input, "\r\n|\r|\n");
            List<string> niceStrings = new List<string>();

            foreach (string element in strings)
            {
                int vowels = 0;
                bool hasDoubles = false;
                bool hasBadStrings = false;

                for (int i = 0; i < element.Length; i++)
                {
                    if (element[i] == 'a' || element[i] == 'e' || element[i] == 'i' || element[i] == 'o' || element[i] == 'u')
                        vowels++;

                    if (i != element.Length - 1)
                    {
                        if (element[i] == element[i + 1])
                            hasDoubles = true;
                        
                        if (element[i] == 'a' && element[i + 1] == 'b')
                            hasBadStrings = true;
                        else if (element[i] == 'c' && element[i + 1] == 'd')
                            hasBadStrings = true;
                        else if (element[i] == 'p' && element[i + 1] == 'q')
                            hasBadStrings = true;
                        else if (element[i] == 'x' && element[i + 1] == 'y')
                            hasBadStrings = true;
                    }
                }

                if (vowels >= 3 && hasDoubles && !hasBadStrings)
                {
                    Console.WriteLine(element);
                    niceStrings.Add(element);
                }
            }

            Console.WriteLine("\nTotal number of nice strings: " + niceStrings.Count);
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
