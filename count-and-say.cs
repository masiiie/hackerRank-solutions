// https://leetcode.com/problems/count-and-say/

using System.Collections.Generic;
using System;

public 

public class Solution {
    public string CountAndSay(int n) {
        
    }

    public string say(string chain){
        Dictionary<char,int> dict = new Dictionary<char, int>();

        for(int i=0; i<chain.Length; i++){
            dict[chain[i]]++;
        }
        
        string sol = "";
        foreach(char key in dict.Keys){
            sol+=dict[key].ToString()+key;
        }
        return sol;
    }
}