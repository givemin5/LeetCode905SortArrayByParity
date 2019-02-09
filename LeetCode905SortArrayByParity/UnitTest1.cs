using System;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode905SortArrayByParity
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] A = new int[]{3,1,2,4};

            Solution solution = new Solution();
            var actual = solution.SortArrayByParity(A);

            var expected = new int[] {2, 4, 3, 1};

            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
