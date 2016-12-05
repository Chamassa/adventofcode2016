using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdventOfCode2016.Code
{
    public class Day1
    {
        public string Puzzle1(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(1);
            string[] instructions = input.Replace("\n", "").Split(',');
            Point position = new Point(0, 0);
            string currentDirection = "U";
            foreach (string instruction in instructions)
            {
                ApplyInstruction(ref position, ref currentDirection, instruction);
            }
            return (Math.Abs(position.X) + Math.Abs(position.Y)).ToString();
        }

        public string Puzzle2(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(1);
            string[] instructions = input.Replace("\n", "").Split(',');
            Point position = new Point(0, 0);
            string currentDirection = "U";
            List<Point> visited = new List<Point>();
            Point lastPosition = new Point(0, 0);
            foreach (string instruction in instructions)
            {
                lastPosition = new Point(position.X, position.Y);
                ApplyInstruction(ref position, ref currentDirection, instruction);
                List<Point> newPoints = new List<Point>();
                bool first = true;
                int xSign = Math.Sign(position.X - lastPosition.X) >= 0 ? 1 : -1;
                int ySign = Math.Sign(position.Y - lastPosition.Y) >= 0 ? 1 : -1;
                for (int x = (int)lastPosition.X; xSign > 0 ? (x <= position.X) : (x >= position.X); x = x + xSign)
                {
                    for (int y = (int)lastPosition.Y; ySign > 0 ? (y <= position.Y) : (y >= position.Y); y = y + ySign)
                    {
                        if (first)
                            first = false;
                        else
                            newPoints.Add(new Point(x, y));
                    }
                }
                if (newPoints.Any(p => visited.Any(p2 => p2.X == p.X && p2.Y == p.Y)))
                {
                    position = newPoints.First(p => visited.Any(p2 => p2.X == p.X && p2.Y == p.Y));
                    break;
                }
                visited = visited.Concat(newPoints).ToList();
            }
            return (Math.Abs(position.X) + Math.Abs(position.Y)).ToString();
        }

        private static void ApplyInstruction(ref Point position, ref string currentDirection, string instruction)
        {
            string direction = instruction.Trim().Substring(0, 1);
            currentDirection = direction == "L" ? (currentDirection == "U" ? "L" : currentDirection == "L" ? "D" : currentDirection == "D" ? "R" : "U") : (currentDirection == "U" ? "R" : currentDirection == "L" ? "U" : currentDirection == "D" ? "L" : "D");
            int amount = int.Parse(instruction.Trim().Substring(1));
            switch (currentDirection)
            {
                case "L":
                    position.X -= amount;
                    break;
                case "U":
                    position.Y -= amount;
                    break;
                case "R":
                    position.X += amount;
                    break;
                case "D":
                    position.Y += amount;
                    break;
            }
        }
    }
}
