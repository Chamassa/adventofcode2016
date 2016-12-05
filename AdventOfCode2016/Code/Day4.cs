using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdventOfCode2016.Code
{
    public class Day4
    {
        public List<KeyValuePair<string, int>> filteredRooms { get; set; }

        public string Puzzle1(string overrideInput = "")
        {
            string input = "";
            if (overrideInput != "")
                input = overrideInput;
            else
                input = DownloadInput.GetInput(4);
            string[] instructions = input.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            filteredRooms = new List<KeyValuePair<string, int>>();
            int sectorSum = 0;
            foreach(string instruction in instructions)
            {
                int sectorIdIndex = instruction.IndexOfAny("0123456789".ToCharArray());
                int checkSumIndex = instruction.IndexOf('[');
                string encName = instruction.Substring(0, sectorIdIndex - 1);
                int sectorId = int.Parse(instruction.Substring(sectorIdIndex, checkSumIndex - sectorIdIndex));
                string checkSum = instruction.Substring(checkSumIndex + 1, 5);
                List<KeyValuePair<char, int>> sorted = encName.Replace("-", "").CharacterCount();
                string generatedSum = string.Join("", sorted.Take(5).Select(x => x.Key));
                if (checkSum == generatedSum)
                {
                    sectorSum += sectorId;
                    filteredRooms.Add(new KeyValuePair<string, int>(encName, sectorId));
                }
            }
            return sectorSum.ToString();
        }

        public string Puzzle2(string overrideInput = "")
        {
            int offset = (int)'a';
            Console.WriteLine("------------\n\n\n");
            Puzzle1(overrideInput);
            foreach(KeyValuePair<string, int> room in filteredRooms)
            {
                string decrypted = "";
                foreach(char c in room.Key)
                {
                    if(c == '-')
                    {
                        decrypted += ' ';
                        continue;
                    }
                    decrypted += (char) ((((((int)c) - offset) + room.Value) % 26) + offset); 
                }
                if (decrypted == "northpole object storage")
                    return room.Value.ToString();
                Console.WriteLine(decrypted + " - " + room.Value.ToString());
            }
            return "";
        }
    }
}
