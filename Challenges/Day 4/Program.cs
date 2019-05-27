using System;
using System.IO;
using System.Security.Cryptography;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = GetInput();
            
            ASide(input);
            // BSide(input);
        }


        static void ASide(string input)
        {
            int i = 0;

            for (i = 282749; MD5Hash(input, i).Substring(0, 5) != "00000"; i++)
            {
                Console.WriteLine("Testing integer: " + i.ToString() + "   First five characters: " + MD5Hash(input, i).Substring(0, 5));
            }

            Console.WriteLine("\nOutput hash: " + MD5Hash(input, i));
            Console.WriteLine("Lowest possible number: " + i);
        }


        static void BSide(string input)
        {
            int i = 9962624; // this took 30 minutes to compute...
            
            for (i = 0; MD5Hash(input, i).Substring(0, 6) != "000000"; i++)
            {
                Console.WriteLine("Testing integer: " + i.ToString() + "   First six characters: " + MD5Hash(input, i).Substring(0, 6));
            }

            Console.WriteLine("\nOutput hash: " + MD5Hash(input, i));
            Console.WriteLine("Lowest possible number: " + i);
        }


        static string GetInput()
        {
            string fileContent = "[Empty File]";

            if (File.Exists("Input.txt"))
                fileContent = File.ReadAllText("Input.txt");

            return fileContent;
        }


        static string MD5Hash(string inputString, int inputInteger = 1)
        {
            string inputKey = inputString + inputInteger.ToString();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(inputKey);
            byte[] hashBytes = MD5.Create().ComputeHash(inputBytes);
            System.Text.StringBuilder builder = new System.Text.StringBuilder();

            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("X2"));
            }
            
            return builder.ToString();
        }
    }
}
