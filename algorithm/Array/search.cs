public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        if(nums.Length == 0) return -1;
        int l = 0, r = nums.Length - 1;
        while(l <= r)
        {
            var mid = (l + r) / 2;
            if(nums[mid] == target) return mid;
            else if(nums[mid] < nums[r])
            {
                if(nums[mid] < target && nums[r] >= target) l = mid + 1;
                else r = mid - 1;
            }
            else
            {
                if(nums[l] <= target && nums[mid] > target) r = mid - 1;
                else l = mid + 1;
            }
        }

        return -1;
    }
}