public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        if(strs.Length == 0) return "";
        
        string std = strs[0];
        int maxLen = std.Length;
        
        for(int i = 1;i < strs.Length; i++)
        {
            int len = 0;
            for(int j = 0; j < maxLen && j < strs[i].Length;j++)
            {
                if(j == std.Length || strs[i][j] != std[j]) break;
                len++;
            }
            maxLen = len < maxLen ? len : maxLen;
        }
        
        return std.Substring(0, maxLen);
    }
}