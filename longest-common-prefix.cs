// https://leetcode.com/problems/longest-common-prefix/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 1) return strs[0];
        string longest = "";
        for(int i = 0; i < 200; i++){
            char actual;
            if(i < strs[0].Length) actual = strs[0][i];
            else return longest;
            for(int j = 1; j < strs.Length; j++){
                if(i >= strs[j].Length || strs[j][i] != actual) return longest;
            }
            longest += actual;
        }

        return longest;
    }
}