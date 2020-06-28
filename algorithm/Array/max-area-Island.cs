public class Solution 
{
    private int _temp = 0;
    public int MaxAreaOfIsland(int[][] grid) 
    {
        var ret = 0;
        for(var i = 0; i < grid.Length; i++)
        {
            for(var j = 0; j < grid[0].Length; j++)
            {
                FindNext(i, j, ref grid);
                ret = _temp > ret ? _temp : ret;
                _temp = 0;
            }
        }

        return ret;
    }

    private void FindNext(int x, int y, ref int[][] grid)
    {
        if(grid[x][y] == 1)
        {
            grid[x][y] = 0;
            if(x + 1 < grid.Length) FindNext(x + 1, y, ref grid);
            if(y + 1 < grid[0].Length) FindNext(x, y + 1, ref grid);
            if(x - 1 >= 0) FindNext(x - 1, y, ref grid);
            if(y - 1 >= 0) FindNext(x, y -1, ref grid);
            _temp += 1;
        }
        else
        {
            return;
        }
    }
}