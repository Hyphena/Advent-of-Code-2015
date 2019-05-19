using System;
using System.IO;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary myLib = new MyLibrary();
            string input = myLib.GetInput();
            int currentFloor = 0;

            foreach(char parenthesis in input)
            {
                if (parenthesis == '(')
                    currentFloor++;
                else if (parenthesis == ')')
                    currentFloor--;
            }

            Console.WriteLine("Santa arrives at floor " + currentFloor);
        }
    }
}
