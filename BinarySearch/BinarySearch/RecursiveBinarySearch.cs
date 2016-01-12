using System;
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
    public class RecursiveBinarySearch
    {
        public static int Search(int[] array, int key)
        {
            return DoSearch(array, key, 0, array.Length);
        }

        public static int DoSearch(int[] array, int key, int left, int right)
        {
            int middle = (left + right) / 2;
            left = 0;
            right = array.Length;

            if (right < left)
                return -1;
            else if (array[middle] > key)
                return DoSearch(array, key, left, middle - 1);
            else if (array[middle] < key)
                return DoSearch(array, key, middle + 1, right);
            else
                return array[middle];
        }
    }
}
