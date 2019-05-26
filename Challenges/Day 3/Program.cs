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


            Console.WriteLine("Total Houses Delivered To: " + houses.Count);
        }


        static void BSide(string input)
        {
            List<House> houses = new List<House>();
            List<House> roboHouses = new List<House>();
            int santaX = 0;
            int santaY = 0;
            int roboX = 0;
            int roboY = 0;
            bool currentTurn = false;
            bool houseExists = false;


            houses.Add(new House(0, 0));
            houses[0].counter++;
            foreach (char dir in input)
            {
                if (!currentTurn)
                {
                    currentTurn = true;

                    if (dir == '^')
                        santaY++;
                    if (dir == '>')
                        santaX++;
                    if (dir == 'v')
                        santaY--;
                    if (dir == '<')
                        santaX--;
                    
                    houseExists = false;
                    foreach (House house in houses)
                    {
                        if (house.x == santaX && house.y == santaY)
                        {
                            houseExists = true;
                            house.counter++;
                            break;
                        }
                    }

                    if (!houseExists)
                    {
                        houses.Add(new House(santaX, santaY));
                    }
                }
                else
                {
                    currentTurn = false;

                    if (dir == '^')
                        roboY++;
                    if (dir == '>')
                        roboX++;
                    if (dir == 'v')
                        roboY--;
                    if (dir == '<')
                        roboX--;
                    
                    houseExists = false;
                    foreach (House house in houses)
                    {
                        if (house.x == roboX && house.y == roboY)
                        {
                            houseExists = true;
                            house.counter++;
                            break;
                        }
                    }

                    if (!houseExists)
                    {
                        houses.Add(new House(roboX, roboY));
                    }
                }
            }


            foreach (House house in houses)
            {
                if (house.x == santaX && house.y == santaY)
                {
                    house.counter++;
                    break;
                }
            }


            Console.WriteLine("\nTotal Houses Delivered To: " + (houses.Count + roboHouses.Count));
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
