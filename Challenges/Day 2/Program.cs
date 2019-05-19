using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day_2
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
            // TODO: Skip over improperly formatted strings
            string[] wrappingPaper = Regex.Split(input, "\r\n|\r|\n");
            int totalWrappingPaper = 0;

            foreach (string element in wrappingPaper)
            {
                int[] dimensions = Regex.Split(element, "x").Select(n => Convert.ToInt32(n)).ToArray();

                Array.Sort(dimensions);
                int length = dimensions[0];
                int width = dimensions[1];
                int height = dimensions[2];

                int surfaceArea = (2 * length * width) + (2 * width * height) + (2 * length * height);
                int smallestArea = length * width;

                totalWrappingPaper += surfaceArea + smallestArea;
            }

            Console.WriteLine("[A-SIDE] The elves will need to order " + totalWrappingPaper + " sqft. of wrapping paper");
        }


        static void BSide(string input)
        {
            // TODO: Skip over improperly formatted strings
            string[] wrappingPaper = Regex.Split(input, "\r\n|\r|\n");
            int totalRibbonLength = 0;

            foreach (string element in wrappingPaper)
            {
                int[] dimensions = Regex.Split(element, "x").Select(n => Convert.ToInt32(n)).ToArray();

                Array.Sort(dimensions);
                int length = dimensions[0];
                int width = dimensions[1];
                int height = dimensions[2];

                int smallestPerimeter = (2 * length) + (2 * width);
                int boxVolume = length * width * height;

                totalRibbonLength += smallestPerimeter + boxVolume;
            }

            Console.WriteLine("[B-SIDE] The elves will need to order " + totalRibbonLength + " feet of ribbon");
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
