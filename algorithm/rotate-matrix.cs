public class Solution 
{
    public void Rotate(int[][] matrix) 
    {
        var n = matrix.Length;
        //获得大小

        for(var i = 0; i < n / 2; i++) //水平翻转
        {
            for(var j = 0; j < n; j++)
            {
                Swap(ref matrix[i][j], ref matrix[n - i - 1][j]);
            }
        }
        
        for(var i = 0; i < n; i++) //对角线翻转
        {
            for(var j = 0; j < i; j++)
            {
                Swap(ref matrix[i][j], ref matrix[j][i]);
            }
        }
    }

    private void Swap(ref int a, ref int b)
    {
        a = a ^ b;
        b = b ^ a;
        a = a ^ b;
    }
}