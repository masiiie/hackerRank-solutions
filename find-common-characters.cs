using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        bool endApp = false;
        // Display title as the C# console calculator app.
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");  
    }
}

public class Solution {
    public IList<string> CommonChars(string[] words) {
        string sol = words[0];

        foreach(string x in words){
            string toRemove = new List<char>();
            for(int i=0;i<sol.Length;i++) if(!x.Contains(sol[i])) toRemove.Add(sol[i]);
            
        }

        return sol.Select(c => c.ToString()).ToList();
    }
}