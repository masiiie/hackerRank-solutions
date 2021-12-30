
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.LengthOfLastWord("Hola te amo                         ejeje"));
    }
}

public class Solution {
    public int LengthOfLastWord(string s) {
        int len = 0;
        for(int i=0;i<s.Length;i++){
            if(s[i]!=' ') len++;
            else len = 0;
        }
        return len;
    }
}