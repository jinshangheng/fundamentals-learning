using System.Collections.Generic;

public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        var hash = new HashSet<char>();
        //重复查询哈希图

        var i = 0;
        var j = 0;
        //滑动窗口游标

        var ret = 0;
        //返回值
        while(i < s.Length) //主循环体，左窗口的游历过程
        {
            j = i; //向左对齐

            while(!hash.Contains(s[j])) //副循环体，右窗口的游历过程
            {
                hash.Add(s[j]);
                j++;
                if(j >= s.Length) break;
            }

            ret = hash.Count >= ret ? hash.Count : ret; //冒泡，取最大值
            hash.Clear(); //清空哈希图
            i++;
        }

        return ret;
    }
}