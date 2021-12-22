// https://leetcode.com/problems/longest-common-prefix/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string longest = "";
        for(int i = 0; i < 200; i++){
            for(int j = 0; j < strs.Length; j++){
                if(i < strs[j].Length)
                {

                }
                else{
                    return longest;
                }
            }
        }

        return longest;
    }
}