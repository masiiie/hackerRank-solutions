// https://leetcode.com/problems/count-and-say/

using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.CountAndSay(5));
    }
}

public class Solution {
    public string CountAndSay(int n) {
        if(n==1) return "1";
        else return say(CountAndSay(n-1));
    }

    public string say(string chain){
        if(chain.Length == 1) return "1"+chain;
        string sol = "";
        char actualNumber = chain[0];
        int count = 1;

        for(int i=1; i<chain.Length; i++){
            if(chain[i]!=actualNumber){
                sol+=count.ToString()+actualNumber;
                actualNumber=chain[i];
                count=1;
            }
            else count++;
        }

        sol+=count.ToString()+actualNumber;
        
        return sol;
    }
}