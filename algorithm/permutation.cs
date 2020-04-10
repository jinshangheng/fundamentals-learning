public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1 == string.Empty || s2 == string.Empty || s1.Length > s2.Length) return false;
        //排除掉一些极端的情况

        var cArray = new int[26];
        //字母表

        for (var i = 0; i < s1.Length; i++)
        {
            cArray[s1[i] - 'a']++;
            cArray[s2[i] - 'a']--;
        }
        //初始化滑块为 0 - s1.Length 的情况

        for (var i = s1.Length; i < s2.Length; i++)
        {
            if (IsSame(cArray)) return true;

            cArray[s2[i - s1.Length] - 'a']++;
            cArray[s2[i] - 'a']--;
        }
        //以滑动窗口的方式遍历s2

        return IsSame(cArray);
    }

    private bool IsSame(int[] cArray)
    {
        foreach (var count in cArray)
        {
            if (count != 0) return false;
        }
        return true;
    }
}