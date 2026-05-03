using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace adventofcode2015.day01
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int floor = 0;

            foreach (string line in File.ReadLines("inputs/day01.txt"))
            {
                foreach (char character in line)
                {
                    if (character.Equals('('))
                    {
                        floor++;
                    }
                    else
                    {
                        floor--;
                    }
                }
            }
            Console.WriteLine("Final Floor: "+floor);
        }
    }
}