using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string SimplifyPath(string path)
    {
        if (string.IsNullOrWhiteSpace(path)) return "/";
        //空情况排查

        var temp = string.Empty;
        var dic = new Stack<string>();
        //阅读临时变量，目录索引栈

        foreach (var c in path)
        {
            if (c != '/')
            {
                temp += c;
            }
            else
            {
                switch (temp)
                {
                    case ".":
                        temp = string.Empty;
                        break;
                    case "..":
                        {
                            if (dic.Any()) dic.Pop();
                            break;
                        }
                    default:
                        if (!string.IsNullOrEmpty(temp)) dic.Push(temp);
                        break;
                }

                temp = string.Empty;
            }
        }

        if (!string.IsNullOrEmpty(temp) && temp != ".")
        {
            if (temp == "..")
            {
                if (dic.Any()) dic.Pop();
            }
            else
            {
                dic.Push(temp);
            }
        }

        temp = string.Empty;

        while (dic.Any())
        {
            temp = '/' + dic.Pop() + temp;
        }

        return !string.IsNullOrEmpty(temp) ? temp : "/";
    }
}
{
    public string SimplifyPath(string path)
{
    if (string.IsNullOrWhiteSpace(path)) return "/";
    //空情况排查

    var temp = string.Empty;
    var dic = new Stack<string>();
    //阅读临时变量，目录索引栈

    foreach (var c in path)
    {
        if (c != '/')
        {
            temp += c;
        }
        else
        {
            if (temp == ".")
            {
                temp = string.Empty;
            }
            else if (temp == "..")
            {
                if (dic.Any()) dic.Pop();
            }
            else
            {
                dic.Push(temp);
            }

            temp = string.Empty;
        }
    }

    if (!string.IsNullOrEmpty(temp) && temp != ".")
    {
        if (temp == "..")
        {
            if (dic.Any()) dic.Pop();
        }
        else
        {
            dic.Push(temp);
        }
    }

    temp = string.Empty;

    while (dic.Any())
    {
        temp = '/' + dic.Pop() + temp;
    }

    return string.IsNullOrEmpty(temp) ? temp : "/";
}
}