using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class IsomorphicStrings_205
    {
        public bool IsIsomorphic(string s, string t)
        {
            var mapSToT = new Dictionary<char, char>();
            var mappedT = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (mapSToT.ContainsKey(s[i]) ^ mappedT.Contains(t[i]))
                {
                    return false;
                }

                if (!mapSToT.ContainsKey(s[i]))
                {
                    mapSToT[s[i]] = t[i];
                    mappedT.Add(t[i]);
                    continue;
                }

                if (mapSToT[s[i]] != t[i])
                {
                    return false;
                }
            }

            return true;
        }


        public void Test()
        {
            var s = "aba";
            var t = "122";

            var k = IsIsomorphic(s, t);

            Console.WriteLine();
        }
    }
}
