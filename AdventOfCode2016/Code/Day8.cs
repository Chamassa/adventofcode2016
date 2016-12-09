using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdventOfCode2016.Code
{
    public class Day8
    {
        bool[][] Display = null;

        public string Puzzle1(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(8);
            string[] instructions = input.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            bool[][] display = new bool[6][] { new bool[50], new bool[50], new bool[50], new bool[50], new bool[50], new bool[50] };
            foreach (string instruction in instructions)
            {
                var instr = instruction.Trim();
                string[] split = instr.Split(' ');
                if (split[0] == "rect")
                {
                    string[] rect = split[1].Split('x');
                    int yVal = int.Parse(rect[0]);
                    int xVal = int.Parse(rect[1]);
                    for (int y = 0; y < yVal; y++)
                    {
                        for (int x = 0; x < xVal; x++)
                        {
                            display[x][y] = true;
                        }
                    }
                }
                else
                {
                    if (split[1] == "column")
                    {
                        int xVal = int.Parse(split[2].Substring(2));
                        bool[] orig = display.Select(y => y[xVal]).ToArray();
                        int splitOn = int.Parse(split[4]) % 6;
                        if (splitOn != 0 && splitOn != 6)
                            orig = orig.Skip(6 - splitOn).Concat(orig.Take(6 - splitOn)).ToArray();
                        for (int y = 0; y < 6; y++)
                            display[y][xVal] = orig[y];
                    }
                    else
                    {
                        int yVal = int.Parse(split[2].Substring(2));
                        bool[] orig = (bool[])display[yVal].Clone();
                        int splitOn = int.Parse(split[4]) % 50;
                        if (splitOn != 0 && splitOn != 50)
                            orig = orig.Skip(50 - splitOn).Concat(orig.Take(50 - splitOn)).ToArray();
                        for (int x = 0; x < 50; x++)
                            display[yVal][x] = orig[x];
                    }
                }
            }
            Display = display;
            return display.Select(y => y.Count(p => p == true)).Sum().ToString();
        }

        public string Puzzle2(string overrideInput = "")
        {
            Puzzle1(overrideInput);
            string output = "";

            
            for (int y = 0; y < 6; y++)
                output += string.Join(" ", Display[y].Select(p => p ? '#' : '.')) + "\n";
            return output.ToString();
        }
    }
}
