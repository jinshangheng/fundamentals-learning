using System.Collections.Generic;
using System;
public class Solution 
{
    class IntervalCompare : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return x[0] - y[0];
        }
    }
    public int[][] Merge(int[][] intervals) 
    {
        if(intervals.Length < 2) return intervals;
        Array.Sort(intervals, new IntervalCompare());

        var list = new List<int[]>();
        for(int i = 0; i < intervals.Length - 1; i++)
        {
            if(intervals[i + 1][0] <= intervals[i][1])
            {
                intervals[i + 1][0] = intervals[i][0];
                intervals[i + 1][1] = Math.Max(intervals[i + 1][1], intervals[i][1]);
            } 
            else
            {
                list.Add(intervals[i]);
            }
        }

        list.Add(intervals[intervals.Length - 1]);
        var ret = new int[list.Count][];
        for (int i = 0; i < list.Count; i++)
        {
            ret[i] = new int[2];
            ret[i][0] = list[i][0];
            ret[i][1] = list[i][1];
        }

        return ret;
    }
}