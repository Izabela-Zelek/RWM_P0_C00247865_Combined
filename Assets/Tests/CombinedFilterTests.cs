using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 24, 2, 720, 120, 720, 120, 720, 120, 720, 120 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

