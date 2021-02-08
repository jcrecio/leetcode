public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j && nums[i] + nums[j] == target)
                {
                    return new[] { i, j };
                }
                if (nums.Length - 1 - j != i && nums[i] + nums[nums.Length - 1 - j] == target)
                {
                    return new[] { i, nums.Length - 1 - j };
                }
            }
        }
        return new int[] { };
    }
}