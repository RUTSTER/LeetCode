using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class BestTimeToBuyAndSellStock2_122
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {                
                    profit += prices[i] - prices[i - 1];
                }
            }

            return profit;
        }

        public void Test()
        {
            int[] num = [7, 1, 5, 3, 6, 4];

            var k = MaxProfit(num);

            Console.WriteLine();
        }
    }
}
