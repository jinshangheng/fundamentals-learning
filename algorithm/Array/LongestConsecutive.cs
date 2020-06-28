using System;
using System.Linq;

public class Solution 
{
    public int LongestConsecutive(int[] nums) 
    {
        if(nums.Length == 0) return 0;

        nums = nums.GroupBy(a => a).Select(a => a.Key).OrderBy(a => a).ToArray();
        var ret = 1;
        var temp = 1;
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if(nums[i] == nums[i + 1] - 1)
            {
                temp++;
            }
            else
            {
                ret = temp > ret ? temp : ret;
                temp = 1;
            }
        }
        return temp > ret ? temp : ret;
    }
}