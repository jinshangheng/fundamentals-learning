using System.Collections.Generic;

public class Solution 
{
    public string ReverseWords(string s) 
    {
        if(string.IsNullOrWhiteSpace(s)) return "";

        var resultWords = new Stack<string>();
        var temp = string.Empty;

        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] != ' ')
            {
                temp += s[i];
            }
            else
            {
                if(!string.IsNullOrEmpty(temp)) resultWords.Push(temp);
                temp = string.Empty;
            }

            if(i == s.Length - 1)
            {
                if(!string.IsNullOrEmpty(temp)) resultWords.Push(temp);
            }
        }

        var ret = string.Empty;
        while(resultWords.Count > 1)
        {
            ret += resultWords.Pop() + ' ';
        }

        ret += resultWords.Pop();
        return ret;
    }
}