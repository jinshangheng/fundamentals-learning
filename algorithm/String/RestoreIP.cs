using System.Collections.Generic;

public class Solution 
    {
        public IList<string> RestoreIpAddresses(string s) 
        {
            if(s.Length < 4 || s.Length > 12) return new List<string>();
            
            var ret = new List<string>();
            //返回容器

            string p1,p2,p3,p4;
            //ip地址的四段

            for(var i = 1; i < 4; i++)
            {
                if(i >= s.Length) break;
                p1 = s.Substring(0, i);
                if(!IsNum(p1)) continue;

                for(var j = 1; j < 4; j++)
                {
                    if(i + j >= s.Length) break;
                    p2 = s.Substring(i, j);
                    if(!IsNum(p2)) continue;

                    for(var k = 1; k < 4; k++)
                    {
                        if(i + j + k >= s.Length) break;
                        p3 = s.Substring(i + j, k);
                        p4 = s.Substring(i + j + k);
                        if(!IsNum(p3) || !IsNum(p4)) continue;

                        ret.Add(p1 + "." + p2 + "." + p3 + "." + p4);
                    }
                }
            }

            return ret;
        }

        private bool IsNum(string num)
        {
            var sum = 0;
            var pos = 1;
            if(num.Length != 1 && num[0] == '0') return false;
            for(var i = num.Length - 1; i >= 0; i--)
            {
                sum += (num[i] - '0') * pos;
                pos *= 10;
            }

            return sum <= 255;
        }
    }