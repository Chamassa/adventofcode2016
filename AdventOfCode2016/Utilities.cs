using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2016
{
    public static class Utilities
    {
        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }

        public static List<KeyValuePair<char, int>> CharacterCount(this string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            foreach (var character in str)
            {
                if (!characterCount.ContainsKey(character))
                    characterCount.Add(character, 1);
                else
                    characterCount[character]++;
            }

            return (from entry in characterCount orderby entry.Value descending, entry.Key ascending select entry).ToList();
        }

    }
}
