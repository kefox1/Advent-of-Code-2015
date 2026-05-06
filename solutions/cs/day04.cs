using System.Security.Cryptography;
using System;
using System.Diagnostics;

namespace adventofcode2015.day04
{
    public class Solution
    {
        static void Main(string[] args)
        {
            foreach (string input in File.ReadLines("inputs/day04.txt"))
            {
                int key = CalculateHash(input);
                Console.WriteLine("Number: "+key);
            }
        }

        static int CalculateHash(string input)
        {
            int suffixNum = 0;
            while (true)
            {
                string hash = CreateMD5(input+suffixNum.ToString());
                if (hash.Substring(0,5) == "00000")
                {
                    return suffixNum;
                }
                suffixNum++;
            }
        }

        static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
    }
}