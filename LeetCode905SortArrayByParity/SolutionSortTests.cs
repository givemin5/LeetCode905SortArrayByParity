using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode905SortArrayByParity
{
    [TestClass]
    public class SolutionSortTests
    {
        [TestMethod]
        public void SolutionSortArrayByParity_3_1_2_4_ShouldBe_2_4_3_1()
        {
            int[] A = new int[]{3,1,2,4};

            Solution solution = new Solution();
            var actual = solution.SortArrayByParity(A);

            var expected = new int[] {2, 4, 3, 1};

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
