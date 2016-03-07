using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem.ZeroOne
{
    public class BruteForceKnapsack
    {
        private int items;
        private int capacity;
        private int[] values = { 4, 2, 10, 1, 2 };
        private int[] weights = { 12, 1, 4, 1, 2 };
        private string[] packedItems;
        private int bestValue = 0;

        public BruteForceKnapsack()
        {
            this.items = 5;
            this.capacity = 15;
            this.packedItems = new string[this.items];
            this.bestValue = 0;
        }

        /// <summary>
        /// Brute-force algorithm working in c*2^n.
        /// 
        /// Assignments and comporisons made in solve all run in O(1).
        /// Recursion depth is n with 2 recursive calls in each run, resulting in 2^n runs total.
        /// Runtime is thus not only bound by O(2^n), but also of the form c*2^n as requested.
        /// 
        /// Ref: http://cs.stackexchange.com/questions/33105/brute-force-method-to-solve-the-0-1-knapsack-problem
        /// </summary>
        public void Solve()
        {
            this.SolveRecursively(this.items - 1, 0, 0);
        }

        private void SolveRecursively(int items, int currentWeight, int currentValue)
        {
            if (items == 0 && currentWeight <= capacity && currentValue > bestValue)
                this.bestValue = currentValue;

            if (items == 0)
                return;

            // Don't pack this item.
            SolveRecursively(items - 1, currentWeight, currentValue);

            // Pack this item.
            SolveRecursively(items - 1, currentWeight + weights[items], currentValue + values[items]);
            this.packedItems[items] = "Value:" + values[items] + "Weight:" + weights[items];
        }

        public void PrintItems()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(packedItems[i]);
        }

        static void Main(string[] args)
        {
            BruteForceKnapsack bfn = new BruteForceKnapsack();
            bfn.Solve();

            Console.WriteLine(bfn.bestValue);
            bfn.PrintItems();
        }
    }
}
