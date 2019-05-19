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
            
            ASide(input);
            BSide(input);
        }


        static void ASide(string input)
        {
            int currentFloor = 0;

            foreach(char parenthesis in input)
            {
                if (parenthesis == '(')
                    currentFloor++;
                else if (parenthesis == ')')
                    currentFloor--;
            }

            Console.WriteLine("[A-SIDE] Santa arrives at floor " + currentFloor);
        }


        static void BSide(string input)
        {
            int currentFloor = 0;
            int currentChar = 0;

            foreach(char parenthesis in input)
            {
                currentChar++;

                if (parenthesis == '(')
                    currentFloor++;
                else if (parenthesis == ')')
                    currentFloor--;

                if (currentFloor < 0)
                    break;
            }

            Console.WriteLine("[B-SIDE] Santa first enters the basement on parenthesis " + currentChar);
        }
    }
}
