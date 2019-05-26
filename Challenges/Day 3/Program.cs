using System;
using System.Collections.Generic;
using System.IO;

namespace Day_3
{
    class House
    {
        public int x, y;
        public int counter = 0;

        public House()
        {
            x = 0;
            y = 0;
            counter = 0;
        }

        public House(int x, int y)
        {
            this.x = x;
            this.y = y;
            counter++;
        }
    }

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
            List<House> houses = new List<House>();
            int x = 0;
            int y = 0;
            bool houseExists = false;


            houses.Add(new House(0, 0));
            foreach (char dir in input)
            {
                if (dir == '^')
                    y++;
                if (dir == '>')
                    x++;
                if (dir == 'v')
                    y--;
                if (dir == '<')
                    x--;


                houseExists = false;
                foreach (House house in houses)
                {
                    if (house.x == x && house.y == y)
                    {
                        houseExists = true;
                        house.counter++;
                        break;
                    }
                }

                if (!houseExists)
                {
                    houses.Add(new House(x, y));
                }
            }


            foreach (House house in houses)
            {
                if (house.x == x && house.y == y)
                {
                    houseExists = true;
                    house.counter++;
                    break;
                }
            }


            foreach (House house in houses)
            {
                Console.WriteLine("X: " + house.x.ToString() + "   Y: " + house.y.ToString() + "   Deliveries: " + house.counter);
            }


            Console.WriteLine("\nTotal Houses Delivered To: " + houses.Count);
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
