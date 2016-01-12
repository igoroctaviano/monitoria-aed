using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearch;
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
namespace BinarySearch.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        private int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestMethod()]
        public void SearchTest()
        {
            Assert.AreEqual(1, RecursiveBinary.Search(array, 1));
            Assert.AreEqual(2, RecursiveBinary.Search(array, 2));
            Assert.AreEqual(3, RecursiveBinary.Search(array, 3));
            Assert.AreEqual(4, RecursiveBinary.Search(array, 4));
            Assert.AreEqual(5, RecursiveBinary.Search(array, 5));
            Assert.AreEqual(6, RecursiveBinary.Search(array, 6));
            Assert.AreEqual(7, RecursiveBinary.Search(array, 7));
            Assert.AreEqual(8, RecursiveBinary.Search(array, 8));
            Assert.AreEqual(9, RecursiveBinary.Search(array, 9));
            Assert.AreEqual(10, RecursiveBinary.Search(array, 10));
        }
    }
}