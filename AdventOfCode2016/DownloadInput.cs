using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2016
{
    public static class DownloadInput
    {
        private static string SessionId = "removed_for_github";
        public static string GetInput(int day, int puzzle)
        {
            string output = "";
            using(WebClient wc = new WebClient())
            {
                wc.Headers.Add("Cookie", "session="+SessionId);
                output = wc.DownloadString("http://adventofcode.com/2016/day/" + day + "/input");
            }
            return output;
        }
    }
}
