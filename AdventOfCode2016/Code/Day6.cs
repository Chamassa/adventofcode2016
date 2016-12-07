using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdventOfCode2016.Code
{
    public class Day6
    {
        public string Puzzle1(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(6);
            string[] instructions = input.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string output = "";
            int width = instructions[0].Trim().Length;
            char[,] chars = new char[instructions[0].Trim().Length, instructions.Length];
            for(int i = 0; i < instructions.Length; i++)
            {
                for (int j = 0; j < width; j++)
                    chars[j,i] = instructions[i].Trim()[j];
            }

            for (int i = 0; i < width; i++){
                char[] row = new char[instructions.Length];
                for (int j = 0; j < instructions.Length; j++)
                    row[j] = chars[i,j];
                var x = new string(row).CharacterCount();
                output += x.First().Key;
            }
                

            return output;
        }

        public string Puzzle2(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(6);
            string[] instructions = input.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string output = "";
            int width = instructions[0].Trim().Length;
            char[,] chars = new char[instructions[0].Trim().Length, instructions.Length];
            for (int i = 0; i < instructions.Length; i++)
            {
                for (int j = 0; j < width; j++)
                    chars[j, i] = instructions[i].Trim()[j];
            }

            for (int i = 0; i < width; i++)
            {
                char[] row = new char[instructions.Length];
                for (int j = 0; j < instructions.Length; j++)
                    row[j] = chars[i, j];
                var x = new string(row).CharacterCount();
                output += x.Last().Key;
            }


            return output;
        }
    }
}
