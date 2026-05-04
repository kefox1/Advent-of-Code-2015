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

            int[] faces = new int[3];
            int[] edges = new int[3];

            int presentSqft;
            int presentSlack;
            int longestEdge;
            int ribbonWrap;
            int ribbonBow;

            int totalPaper = 0;
            int totalRibbon = 0;
            
            foreach (string line in File.ReadLines("inputs/day02.txt"))
            {
                string[] dimensions = line.Split('x');
                l = Int32.Parse(dimensions[0]);
                w = Int32.Parse(dimensions[1]);
                h = Int32.Parse(dimensions[2]);

                edges[0] = l;
                edges[1] = w;
                edges[2] = h;
                Array.Sort(edges);

                faces[0] = l*w;
                faces[1] = w*h;
                faces[2] = h*l;
                Array.Sort(faces);

                presentSqft = 0;
                foreach (int face in faces)
                {
                    presentSqft += 2 * face;
                }
                presentSlack = faces[0];
                totalPaper += presentSqft + presentSlack;

                ribbonWrap = edges[0] * 2 + edges[1] * 2;
                ribbonBow = l * w * h;
                totalRibbon += ribbonWrap + ribbonBow;
            }
            Console.WriteLine("Total Wrapping Paper Needed: " + totalPaper + "sqft");
            Console.WriteLine("Total Ribbon Needed: " + totalRibbon + "ft");
        }
    }
}