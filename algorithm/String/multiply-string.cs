using System.Collections.Generic;

public class Solution 
{
    public string Multiply(string num1, string num2) 
    {
        if (num1 == "0" || num2 == "0") return "0";

        var l = new List<int>();
        for(var i = 0; i < num1.Length + num2.Length - 1; i++)
        {
            l.Add(0);
        }

        for(var i = 0; i < num1.Length; i++)
        {
            for(var j = 0; j < num2.Length; j++)
            {
                l[i + j] += (num1[num1.Length - i - 1] - '0') * (num2[num2.Length - j -1] - '0');
            }
        }

        return ToDecimal(l);
    }

    private string ToDecimal(List<int> l)
    {
        var ret = string.Empty;

        for(var i = 0; i < l.Count - 1; i++)
        {
            l[i + 1] += l[i] / 10;
            l[i] = l[i] % 10;
        }

        for(var i = l.Count - 1; i < l.Count; i++)
        {
            if(l[i] >= 10)
            {
                l.Add(l[i] / 10);
                l[i] = l[i] % 10;
            }
        }

        for(var i = l.Count - 1; i >= 0; i--)
        {
            ret += l[i];
        }

        return ret;
    }
}