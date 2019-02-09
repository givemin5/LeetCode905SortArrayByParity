using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode905SortArrayByParity
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] A)
        {
            return A.OrderBy(x => (x % 2==0)?0:1).ToArray();
        }
    }
}
