using System;
using System.Collections.Generic;
public class Solution 
{
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        var ret = new List<IList<int>>();
        if(nums == null || nums.Length < 3) return ret;

        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > 0) break;
            //只循环小于0的部分，因为是升序排序
            if(i > 0 && nums[i] == nums[i - 1]) continue;
            //去重
            var l = i + 1;
            var r = nums.Length - 1;
            //左右指针，双指针

            while(l < r)
            {
                if(nums[i] + nums[l] + nums[r] == 0)
                {
                    ret.Add(new List<int>(){nums[i], nums[l], nums[r]});
                    while(l < r && nums[l] == nums[l + 1]) l++;
                    while(l < r && nums[r] == nums[r - 1]) r--;
                }
                else if(nums[i] + nums[l] + nums[r] < 0) l++;
                else if(nums[i] + nums[l] + nums[r] > 0) r--;
            }
        }

        return ret;
    }
}