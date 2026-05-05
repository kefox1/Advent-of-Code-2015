using System.Text.RegularExpressions;

namespace adventofcode2015.day05
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int niceStringCount = 0;

            foreach (string line in File.ReadLines("inputs/day05.txt"))
            {
                if (NiceString(line))
                {
                    Console.WriteLine($"{line} is a nice string!");
                    niceStringCount++;
                }
                else
                {
                    Console.WriteLine($"{line} is a naughty string!");
                }
            }
            Console.WriteLine("Nice String Count: " + niceStringCount);
        }

        static bool NiceString(string line)
        {
            if (!DisallowedStringsCheck(line))
            {
                return false;
            }
            if (!VowelCheck(line))
            {
                return false;
            }
            if (!DoubleLetterCheck(line))
            {
                return false;
            }
            return true;
        }

        static bool DisallowedStringsCheck(string line)
        {
            string[] disallowedStrings = {"ab","cd","pq","xy"};
            foreach (string disallowedString in disallowedStrings)
            {
                if (line.Contains(disallowedString))
                {
                    return false;
                }
            }
            return true;
        }

        static bool VowelCheck(string line)
        {
            char[] vowels = {'a','e','i','o','u'};
            int vowelCount = 0;
            foreach (char letter in line)
            {
                foreach (char vowel in vowels)
                {
                    if (letter == vowel)
                    {
                        vowelCount++;
                        if (vowelCount == 3)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        static bool DoubleLetterCheck(string line)
        {
            List<char> checkedChars = new List<char> {};
            foreach (char letter in line)
            {
                if (!checkedChars.Contains(letter))
                {
                    if (line.Contains(new string(letter,2)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}