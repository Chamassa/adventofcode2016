using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdventOfCode2016.Code
{
    public class Day3
    {
        public string Puzzle1(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(3);
            string[] instructions = input.Split('\n');
            int valid = 0;
            foreach(string instruction in instructions)
            {
                string[] split = instruction.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if(split.Length == 3)
                {
                    int[] sides = new int[] { int.Parse(split[0]), int.Parse(split[1]), int.Parse(split[2]) };
                    Array.Sort(sides);
                    valid += (sides[0] + sides[1] > sides[2] ? 1 : 0);
                }
            }
            return valid.ToString();
        }

        public string Puzzle2(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(3);
            string[] instructions = input.Split('\n');
            int valid = 0;
            for(int i = 0; i < instructions.Length - 1; i = i + 3)
            {
                int[][] triangles = new int[3][] { new int[3], new int[3], new int[3] };
                for(int j = 0; j < 3; j++)
                {
                    string[] split = instructions[i+j].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] sides = new int[] { int.Parse(split[0]), int.Parse(split[1]), int.Parse(split[2]) };
                    triangles[0][j] = sides[0];
                    triangles[1][j] = sides[1];
                    triangles[2][j] = sides[2];
                }
                for(int k = 0; k < 3; k++)
                {
                    Array.Sort(triangles[k]);
                    valid += (triangles[k][0] + triangles[k][1] > triangles[k][2] ? 1 : 0);
                }
            }
            return valid.ToString();
        }
    }
}
