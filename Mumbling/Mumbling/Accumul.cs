using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Summary description for Accumul
/// </summary>
public class Accumul
{
    public static String Accum(string source)
    {
        string str = string.Empty;
        char[] strAry = source.ToArray();
        for (int i = 0; i < strAry.Length; i++)
        {
            str += strAry[i].ToString().ToUpper();
            for (int j = 0; j < i; j++)
            {
                str += strAry[i].ToString().ToLower();
            }
            str += "-";
        }
        return str.Substring(0,str.Length-1);
    }
}