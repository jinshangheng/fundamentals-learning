public class Solution {

    public int FindCircleNum(int[][] M) 
    {
        var n = M.Length;
        var ret = 0;
        var visited = new bool[n];
        for(int i = 0; i < n; i++) visited[i] = false;
        
        for(int i = 0; i < n; i++)
        {
            if(visited[i]) continue;

            DFS(M, visited, i);
            ret++;
        }

        return ret;
    }

    private void DFS(int[][] M, bool[] visited, int k)
    {
        visited[k] = true;
        for(int i = 0; i < M.Length; i++)
        {
            if(M[k][i] != 1 || visited[i]) continue;

            DFS(M, visited, i);
        }
    }
}