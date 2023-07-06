using System;

namespace LeetCode.Problems
{
    public static class ContainsDuplicate
    {
        public static bool CheckIfArrayContainsDuplicate(int[] nums)
        {
            if (nums.Length <= 1) return false;
            ISet<int> set = new HashSet<int>();
            set.Add(nums[0]);
            for (int i = 1; i < nums.Length; ++i)
            {
                set.Add(nums[i]);
                if (set.Count < i + 1) return true;
            }

            return false;
        }
    }
}
