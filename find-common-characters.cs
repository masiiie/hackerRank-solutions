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
        IEnumerable<char> sol = words[0].ToCharArray();

        for(int i=0;i<words.Length;i++){
            List<char> solCopy = new List<char>(sol);
            foreach(char charx in sol){
                int index = words[i].IndexOf(charx);
                if(index<0) solCopy.Remove(charx);
                else words[i]=words[i].Remove(index,1);  
            }
            sol = solCopy;
        }

        return sol.Select(c => c.ToString()).ToList();
    }
}