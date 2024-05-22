using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class ZigzagConversion_6
    {
        public string Convert(string s, int numRows)
        {
            if (s.Length <= numRows || numRows == 1)
            {
                return s;
            }

            var converted = new StringBuilder();
            for (int rowI = 0; rowI < numRows; rowI++)
            {
                var currentSourcceIndex = rowI;
                var formulaFlag = true;
                while (currentSourcceIndex < s.Length)
                {
                    converted.Append(s[currentSourcceIndex]);

                    if (rowI == 0 || rowI == numRows - 1)
                    {
                        currentSourcceIndex += 2 * (numRows - 1);
                        continue;
                    }

                    currentSourcceIndex += formulaFlag ? 2 * (numRows - rowI - 1) : 2 * rowI;


                    formulaFlag = !formulaFlag;
                }
            }

            return converted.ToString();
        }

        public void Test()
        {
            var s = "PAYPALISHIRING";

            var res = Convert(s, 5);

            Console.WriteLine();
        }
    }
}
