using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Implementation of Binary Search Algorithm.
/// 
/// Author: Igor Octaviano
/// https://github.com/igoroctaviano/aed
/// </summary>
namespace BinarySearch
{
    public class RecursiveBinary
    {
        public static int Search(int[] array, int key)
        {
            int left = 0, right = array.Length;
            int middle = (left + right) / 2;
            int operations = 0;

            do
            {
                middle = (left + right) / 2;
                if (array[middle] == key)
                {
                    operations++;
                    return array[middle];
                }
                else if (array[middle] >= key)
                    right = middle - 1;
                else
                {
                    left = middle + 1;
                    operations++;
                }
            } while (right >= left);
            return -1;
        }
    }
}
