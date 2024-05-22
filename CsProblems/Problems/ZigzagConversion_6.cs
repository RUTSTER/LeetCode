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

        var rows = new List<StringBuilder>();
        for (int i = 0; i < numRows; i++)
        {
            rows.Add(new StringBuilder());
        }

        var isMoveDown = true;
        var currentRow = 0;
        foreach (var ch in s)
        {
            rows[currentRow].Append(ch);

            currentRow += isMoveDown ? 1 : -1;

            if (currentRow == 0 || currentRow == numRows - 1)
            {
                isMoveDown = !isMoveDown;
            }
        }

        var result = new StringBuilder();
        foreach (var row in rows)
        {
            result.Append(row);
        }

        return result.ToString();
    }

        public void Test()
        {
            var s = "PAYPALISHIRING";

            var res = Convert(s, 5);

            Console.WriteLine();
        }
    }
}
