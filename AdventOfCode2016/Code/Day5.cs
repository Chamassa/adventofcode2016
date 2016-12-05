using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdventOfCode2016.Code
{
    public class Day5
    {
        public List<KeyValuePair<string, int>> filteredRooms { get; set; }

        public string Puzzle1(string i = "")
        {
            string o = "";
            ulong c = 0;
            MD5 md5Hash = MD5.Create();
            while (true)
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(i + c.ToString()));
                
                if (data[0] == 0 && data[1] == 0 && data[2] % 16 == data[2])
                {
                    o += string.Format("{0:X}", data[2]);
                    Console.WriteLine(o + " - " + c);
                    if (o.Length == 8)
                        break;
                }
                c++;
            }
            return o;
        }

        public string Puzzle2(string i = "")
        {
            char[] o = new char[8] { '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0' };

            ulong c = 0;
            int found = 0;
            MD5 md5Hash = MD5.Create();
            while (true)
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(i + c.ToString()));

                if (data[0] == 0 && data[1] == 0 && data[2] % 16 == data[2] && data[2] < 8)
                {
                    if (o[data[2]] == '\0')
                    {
                        o[data[2]] = data[3].ToString("x2")[0];
                        //Console.WriteLine(new string(o) + " - " + c);
                        found++;
                        if (found == 8)
                            break;
                    }
                }
                c++;
            }
            return new string(o);
        }
    }
}
