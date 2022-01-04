using System;

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
        IEnumerable<char> sol = words[0].ToCharArray();

        foreach(string x in words){
            sol = sol.Intersect(x);
        }

        return sol.Select(c => c.ToString()).ToList();
    }
}