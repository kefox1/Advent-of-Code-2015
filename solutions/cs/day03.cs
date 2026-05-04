using System;
using System.Collections.Generic;

namespace adventofcode2015.day03
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int[] soloSantaCoordinates = new int[2];
            int[] duoSantaCoordinates = new int[2];
            int[] duoBotCoordinates = new int[2];

            Dictionary<string,bool> yearOneHousesVisited = new Dictionary<string, bool>();
            Dictionary<string,bool> yearTwoHousesVisited = new Dictionary<string, bool>();

            yearOneHousesVisited[string.Join(",",soloSantaCoordinates)] = true;
            yearTwoHousesVisited[string.Join(",",duoSantaCoordinates)] = true;

            int houseNumber = 0;

            foreach (string line in File.ReadLines("inputs/day03.txt"))
            {
                foreach (char direction in line)
                {
                    soloSantaCoordinates = FindCoordinates(direction,soloSantaCoordinates);
                    yearOneHousesVisited[string.Join(",",soloSantaCoordinates)] = true;

                    houseNumber++;

                    if (houseNumber % 2 == 0)
                    {
                        duoSantaCoordinates = FindCoordinates(direction,duoSantaCoordinates);
                        yearTwoHousesVisited[string.Join(",",duoSantaCoordinates)] = true;
                    }
                    else
                    {
                        duoBotCoordinates = FindCoordinates(direction,duoBotCoordinates);
                        yearTwoHousesVisited[string.Join(",",duoBotCoordinates)] = true;
                    } 
                }
            }
            Console.WriteLine("Year One Houses Visited: " + yearOneHousesVisited.Count);
            Console.WriteLine("Year Two Houses Visited: " + yearTwoHousesVisited.Count);
        }

        static int[] FindCoordinates(char direction, int[] coordinates)
        {
            if (direction == '^')
            {
                coordinates[1] ++;
            }
            else if (direction == 'v')
            {
                coordinates[1] --;
            }
            else if (direction == '>')
            {
                coordinates[0] ++;
            }
            else if (direction == '<')
            {
                coordinates[0] --;
            }
            return coordinates;
        }
    }
}