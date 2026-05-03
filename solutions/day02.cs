using System;

namespace adventofcode2015.day02
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int l;
            int w;
            int h;

            int[] sides = new int[3];

            int presentSqft;
            int presentSlack;

            int totalPaper = 0;
            
            foreach (string line in File.ReadLines("inputs/day02.txt"))
            {
                string[] dimensions = line.Split('x');
                l = Int32.Parse(dimensions[0]);
                w = Int32.Parse(dimensions[1]);
                h = Int32.Parse(dimensions[2]);

                sides[0] = l*w;
                sides[1] = w*h;
                sides[2] = h*l;

                presentSqft = 0;
                presentSlack = sides[0];

                foreach (int side in sides)
                {
                    presentSqft += 2 * side;
                    if (side < presentSlack)
                    {
                        presentSlack = side;
                    }
                }

                totalPaper += presentSqft + presentSlack;
            }
            Console.WriteLine("Total Wrapping Paper Needed: " + totalPaper + "sqft");
        }
    }
}