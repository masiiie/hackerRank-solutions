
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.LengthOfLastWord("luffy is still joyboy"));
    }
}

public class Solution {
    public int LengthOfLastWord(string s) {
        int lastlen = 0;
        int len = 0;
        for(int i=0;i<s.Length;i++){
            if(s[i]!=' ') len++;
            else{
                if(len!=0) lastlen = len;
                len = 0;
            }
        }

        if(len==0 && lastlen!=0) return lastlen;
        return len;
    }
}