using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class GasStation_134
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var stationsCount = gas.Length;

            var relativeCosts = new int[stationsCount];
            for (int i = 0; i < stationsCount; i++)
            {
                relativeCosts[i] = gas[i] - cost[i];
            }

            if (relativeCosts.Sum() < 0)
            {
                return -1;
            }

            var startStation = 0;
            var tank = 0;
            for (int currentStation = 0; currentStation < stationsCount; currentStation++)
            {
                tank += relativeCosts[currentStation];

                if (tank < 0)
                {
                    tank = 0;
                    startStation = currentStation + 1;
                    continue;
                }
            }

            return startStation;
        }

        public void Test()
        {
            int[] gas = [1, 2, 3, 4, 5];
            int[] cost = [3, 4, 5, 1, 2];

            var k = CanCompleteCircuit(gas, cost);

            Console.WriteLine();
        }
    }
}
