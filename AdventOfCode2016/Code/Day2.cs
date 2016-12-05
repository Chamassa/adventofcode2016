using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdventOfCode2016.Code
{
    public class Day2
    {
        public string Puzzle1(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(2);
            string[] instructions = input.Trim().Split('\n');
            int x = 1;
            int y = 1;
            List<int> result = new List<int>();
            foreach (string instruction in instructions)
            {
                foreach (char ch in instruction)
                {
                    switch (ch)
                    {
                        case 'U':
                            y--;
                            break;
                        case 'R':
                            x++;
                            break;
                        case 'L':
                            x--;
                            break;
                        case 'D':
                            y++;
                            break;
                        default:
                            break;
                    }
                    x = x.Clamp(0, 2);
                    y = y.Clamp(0, 2);
                }
                result.Add((x + 1) + (y * 3));
            }
            return string.Join("", result);
        }

        public string Puzzle2(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(2);
            string[] instructions = input.Trim().Split('\n');
            Point location = new Point(0,2);
            string result = "";
            foreach (string instruction in instructions)
            {
                foreach (char ch in instruction)
                {
                    Point move = new Point(0,0);
                    switch (ch)
                    {
                        case 'U':
                            move.Y = -1;
                            break;
                        case 'R':
                            move.X = 1;
                            break;
                        case 'L':
                            move.X = -1;
                            break;
                        case 'D':
                            move.Y = 1;
                            break;
                        default:
                            break;
                    }
                    location = Puz2Move(location, move);
                }
                result += string.Format("{0:X}", ((int)location.X + (new int[] { -1, 1, 5, 9, 11 })[(int)location.Y]));
            }
            return string.Join("", result);
        }

        private Point Puz2Move(Point location, Point move)
        {
            move.X += location.X;
            move.Y += location.Y;
            if(move.Y.Clamp(0,4) == move.Y)
            {
                if(Math.Abs(2 - move.X) + Math.Abs(2 - move.Y) <= 2)
                {
                    location = move;
                }
            }
            return location;    
        }
    }
}


// 0 = 2
// 1 = 1,2,3
// 2 = 0,1,2,3,4,5
// 3 = 1,2,3
// 4 = 2

    //-1, 1, 5, 9, 11