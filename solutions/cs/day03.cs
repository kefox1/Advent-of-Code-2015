using System;
using System.Collections.Generic;

namespace adventofcode2015.day03
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int[] currentCoordinates = new int[2];
            Dictionary<string,int> coordinatePresents = new Dictionary<string, int>();

            foreach (string line in File.ReadLines("inputs/day03.txt"))
            {
                foreach (char direction in line)
                {
                    if (direction == '^')
                    {
                        currentCoordinates[1] ++;
                    }
                    else if (direction == 'v')
                    {
                        currentCoordinates[1] --;
                    }
                    else if (direction == '>')
                    {
                        currentCoordinates[0] ++;
                    }
                    else if (direction == '<')
                    {
                        currentCoordinates[0] --;
                    }

                    if (coordinatePresents.ContainsKey(string.Join(",",currentCoordinates)))
                    {
                        coordinatePresents[string.Join(",",currentCoordinates)]++;
                    }
                    else
                    {
                        coordinatePresents[string.Join(",",currentCoordinates)] = 1;
                    }
                }
            }
            Console.WriteLine("Houses Visited: " + coordinatePresents.Count);
        }
    }
}