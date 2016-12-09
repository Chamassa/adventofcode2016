using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace AdventOfCode2016.Code
{
    public class Day9
    {
        public string Puzzle1(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(9);
            string[] instructions = input.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int output = 0;

            foreach(string instruction in instructions)
            {
                var instr = instruction.Trim();
                int processed = 0;
                string currentStr = instr;
                while(processed < currentStr.Length)
                {
                    if(currentStr[processed] != '(')
                    {
                        processed++;
                    }else
                    {
                        int endTag = currentStr.IndexOf(')', processed);
                        string[] def = currentStr.Substring(processed + 1, (endTag - (processed + 1))).Split('x');
                        currentStr = currentStr.Substring(0, processed) + currentStr.Substring(endTag + 1);
                        int chars = int.Parse(def[0]);
                        int multiply = int.Parse(def[1]);
                        string repeat = currentStr.Substring(processed, chars);
                        string repeated = "";
                        for (int i = 1; i < multiply; i++)
                            repeated += repeat;
                        currentStr = currentStr.Substring(0, processed) + repeated + currentStr.Substring(processed);
                        processed += chars * multiply;
                    }
                }
                Console.WriteLine(instr + " -> " + currentStr + " = " + currentStr.Length);
                output += currentStr.Length;
            }

            return output.ToString();
        }

        public string Puzzle2(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(9);
            string[] instructions = input.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            ulong output = 0;

            foreach (string instruction in instructions)
            {
                var instr = instruction.Trim();
                MatchCollection bitsCollection = Regex.Matches(instr, @"\((.*?)\)|[A-Z]");
                ulong length = 0;
                Set[] bits = bitsCollection.Cast<Match>().Select(m => new Set(m.Value,1)).ToArray();
                for(int i = 0; i < bits.Length; i++)
                {
                    if (bits[i].Key.Length > 1)
                    {
                        string[] cleaned = bits[i].Key.Replace("(","").Replace(")","").Split('x');
                        int chars = int.Parse(cleaned[0]);
                        ulong multiplier = ulong.Parse(cleaned[1]);
                        int handled = 0;
                        int j = 1;
                        while(handled < chars)
                        {
                            //bits[i + j].Value = bits[i + j].Value * multiplier * bits[i].Value;
                            bits[i + j].Value.Add(multiplier);
                            handled += bits[i + j].Key.Length;
                            j++;
                        }
                    }
                    else
                    {
                        length += bits[i].Value.Aggregate((a,b) => a*b);
                    }
                }
                output += length;                
            }

            return output.ToString();
        }

        public class Set
        {
            public string Key { get; set; }
            public List<ulong> Value { get; set; }

            public Set (string key, ulong value)
            {
                Key = key;
                Value = new List<ulong>();
                Value.Add(value);
            }
        }
    }
}
