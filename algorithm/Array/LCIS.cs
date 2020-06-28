public class Solution 
{
    public int FindLengthOfLCIS(int[] nums) 
    {
        if(nums.Length == 0) return 0;
        var ret = 1;
        var temp = 1;
        for(var i = 0; i < nums.Length - 1; i++)
        {
            if(nums[i] < nums[i + 1])
            {
                temp += 1;
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