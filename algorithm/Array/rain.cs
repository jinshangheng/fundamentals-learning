using System.Collections.Generic;
using System.Linq;
public class Solution 
{
    public int Trap(int[] height) 
    {
        if(height.Length == 0) return 0;
        
        var map = new HashSet<int>(height);
        var ret = 0;

        for(var h = map.Max(); h > 0; h--) //h是当前高度
        {
            int left = 0;
            bool isInnerAdd = false;
            while(left < height.Length)
            {
                isInnerAdd = false;
                if(height[left] >= h)
                {
                    int right = left + 1;
                    while(right < height.Length)
                    {
                        if(height[right] >= h)
                        {
                            ret += right - left - 1;
                            left = right;
                            isInnerAdd = true;
                            break;
                        }
                        right++;
                    }
                }

                if(!isInnerAdd) left++;
            }
        }

        return ret;
    }
}