using System.Collections;
public class Solution 
{
    string ret = string.Empty;
    ArrayList al = new ArrayList();
    public string GetPermutation(int n, int k) 
    {
        k = k - 1;

        for(var i = 1; i<= n; i++)
        {
            al.Add(i);
        }

        dp(n, k);
        return ret;
    }

    private void dp(int n, int k)
    {
        if(n == 0) return;

        var index = k / factorial(n - 1);
        k = k % factorial(n - 1);
        ret += al[index].ToString();
        al.Remove(al[index]);
        n = n - 1;

        dp(n, k);
    }

    private int factorial(int num)
    {
        var ret = 1;
        for(var i = num; i > 0; i--)
        {
            ret *= i; 
        }

        return ret;
    }
}