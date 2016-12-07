using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdventOfCode2016.Code
{
    public class Day7
    {
        public string Puzzle1(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(7);
            string[] instructions = input.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int output = 0;

            foreach(string instruction in instructions)
            {
                var instr = instruction.Trim();
                bool requirements = false;
                bool invalid = false;
                bool inBrackets = false;
                for(int i = 0; i < instr.Length - 3 ; i++)
                {
                    if (instr[i] == '[')
                        inBrackets = true;
                    else if (instr[i] == ']')
                        inBrackets = false;
                    else if (instr[i] == instr[i + 3] && instr[i + 1] == instr[i + 2] && instr[i] != instr[i+1])
                    {
                        if (inBrackets)
                        {
                            invalid = true;
                            break;
                        }
                        else
                            requirements = true;
                    }
                }
                if (requirements && !invalid)
                    output++;
            }

            return output.ToString();
        }

        public string Puzzle2(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(7);
            string[] instructions = input.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int output = 0;

            foreach (string instruction in instructions)
            {
                string[] instr = instruction.Trim().Split('[',']');
                string[] outside = new string[(int)Math.Ceiling(((double)instr.Length) / 2)];
                string[] inside = new string[(int)Math.Floor(((double)instr.Length) / 2)];

                bool valid = false;
                for(int i = 0; i < instr.Length; i++)
                {
                    if (i % 2 == 0)
                        outside[i / 2] = instr[i];
                    else
                        inside[(int)Math.Floor(((double)i) / 2)] = instr[i];
                }

                foreach(string outs in outside)
                {
                    if (valid)
                    {
                        break;
                    }
                    for(int i = 0; i < outs.Length - 2; i++)
                    {
                        char[] test = outs.Substring(i, 3).ToCharArray();
                        if(test[0] != test[1] && test[0] == test[2])
                        {
                            if (inside.Any(x => x.Contains(new string(new char[3] { test[1], test[0], test[1] }))))
                            {
                                valid = true;
                                output++;
                                break;
                            }
                        }
                    }
                }
            }

            return output.ToString();
        }
    }
}
