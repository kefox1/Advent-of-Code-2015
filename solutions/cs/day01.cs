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
            int position = 1;
            int firstBasementFloor = 0;

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

                    if (firstBasementFloor == 0)
                    {
                        if (floor == -1)
                        {
                           firstBasementFloor = position; 
                        }
                        position++;
                    }
                }
            }
            Console.WriteLine("Final Floor: "+floor);
            Console.WriteLine("First Basement Floor: "+firstBasementFloor);
        }
    }
}