using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string begging = s.Substring(0, s.Length-2);
        string[] d = begging.Split(':');
        if(s.Substring(s.Length-2, 2) == "AM")
        {
            if(d[0] == "12") return $"00:{d[1]}:{d[2]}";
            return s.Substring(0, s.Length-2);
        }
         
        else
        {
            if(d[0] == "12") return $"12:{d[1]}:{d[2]}";
            int number;
            bool success = int.TryParse(d[0], out number);
            return $"{number + 12}:{d[1]}:{d[2]}";
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}