using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem.ZeroOne
{
    class DynamicKnapsack
    {
        private int capacity;
        private int[] values;
        private int[] weights;
        private int[,] optimalValues;
        private int amountOfDistinctItems;

        /// <summary>
        /// This solution will therefore run in O(nW) time and O(W) space.
        /// Using only a 1-dimensional array m[w] to storen the current optimal
        /// values and pass over this array i+1 times, rewriting from m[W] to m[1] every time.
        /// </summary>
        public void Solve()
        {
            int[] m = new int[this.capacity + 1];

            for (int i = 0; i < this.amountOfDistinctItems; i++)
                for (int j = this.capacity; j >= 0; j--)
                    m[j] = j < weights[i] ? m[j] : Math.Max(m[j], m[j - weights[i]] + values[i]);
        }
    }
}
