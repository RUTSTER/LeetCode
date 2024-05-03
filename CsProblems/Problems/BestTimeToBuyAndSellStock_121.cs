using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class BestTimeToBuyAndSellStock_121
    {
        public int MaxProfit(int[] prices)
        {
            var minIndex = 0;
            var maxIndex = 0;
            var profits = new List<int>() { 0 };

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] < prices[minIndex])
                {
                    minIndex = i; 
                    maxIndex = i;
                }

                if (prices[i] > prices[maxIndex])
                {                
                    maxIndex = i;
                    profits.Add(prices[maxIndex] - prices[minIndex]);
                }
            }

            return profits.Max();
        }

        public void Test()
        {
            int[] num = [7, 1, 5, 3, 6, 4];

            var k = MaxProfit(num);

            Console.WriteLine();
        }
    }
}
